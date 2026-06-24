using DogsBreeds.Business;
using DogsBreeds.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DogsBreeds
{
    public partial class Form1 : Form
    {
        private AnimalLogic animalController = new AnimalLogic();

        private BreedLogic breedController = new BreedLogic();

        private bool allowClose = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Желаете ли да стартирате системата за приют за кучета?",
                "Потвърждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                allowClose = true;
                this.Close();
                return;
            }

            LoadBreeds();
            ShowAllAnimals();
        }

        private void LoadBreeds()
        {
            List<Breed> allBreeds = breedController.GetAllBreeds();

            cmbBreed.DataSource = allBreeds;

            cmbBreed.DisplayMember = "Name";

            cmbBreed.ValueMember = "Id";
        }

        private void LoadRecord(Animal animal)
        {

            txtId.BackColor = Color.White;
            txtName.BackColor = Color.White;
            txtDescription.BackColor = Color.White;
            txtAge.BackColor = Color.White;

            txtId.Text = animal.Id.ToString();
            txtName.Text = animal.Name;
            txtDescription.Text = animal.Description;
            txtAge.Text = animal.Age.ToString();

            cmbBreed.SelectedValue = animal.BreedID;
        }

        private void ClearScreen()
        {
            txtId.BackColor = Color.White;
            txtName.BackColor = Color.White;
            txtDescription.BackColor = Color.White;
            txtAge.BackColor = Color.White;

            txtId.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtAge.Clear();

            if (cmbBreed.Items.Count > 0)
            {
                cmbBreed.SelectedIndex = 0;
            }
        }

        private bool ValidateInput()
        {

            txtName.BackColor = Color.White;
            txtDescription.BackColor = Color.White;
            txtAge.BackColor = Color.White;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show(
                    "Въведете име на животното!",
                    "Липсващи данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtName.BackColor = Color.LightPink;
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show(
                    "Въведете описание на животното!",
                    "Липсващи данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDescription.BackColor = Color.LightPink;
                txtDescription.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAge.Text) || !txtAge.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Въведете коректна възраст!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAge.BackColor = Color.LightPink;
                txtAge.Focus();
                return false;
            }

            int age = int.Parse(txtAge.Text);

            if (age < 0 || age > 30)
            {
                MessageBox.Show(
                    "Въведете реална възраст на кучето!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAge.BackColor = Color.LightPink;
                txtAge.Focus();
                return false;
            }

            if (cmbBreed.SelectedValue == null)
            {
                MessageBox.Show(
                    "Изберете порода!",
                    "Липсващи данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void ShowAllAnimals()
        {

            List<Animal> allAnimals = animalController.GetAll()
                .OrderBy(a => a.Id)
                .ToList();

            lstAnimals.Items.Clear();

            foreach (Animal item in allAnimals)
            {
                lstAnimals.Items.Add($"{item.Id}. {item.Name}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            Animal newAnimal = new Animal();

            newAnimal.Name = txtName.Text;
            newAnimal.Description = txtDescription.Text;
            newAnimal.Age = int.Parse(txtAge.Text);

            newAnimal.BreedID = (int)cmbBreed.SelectedValue;

            animalController.Create(newAnimal);

            MessageBox.Show(
                "Животното е добавено успешно!",
                "Успешно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearScreen();
            ShowAllAnimals();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            int findId = 0;

            if (string.IsNullOrEmpty(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Въведете номер за търсене!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtId.BackColor = Color.LightPink;
                txtId.Focus();
                return;
            }

            findId = int.Parse(txtId.Text);

            Animal findedAnimal = animalController.Get(findId);

            if (findedAnimal == null)
            {
                MessageBox.Show(
                    "Няма животно с такъв номер!",
                    "Няма запис",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtId.BackColor = Color.LightPink;
                txtId.Focus();
                return;
            }

            LoadRecord(findedAnimal);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int findId = 0;

            if (string.IsNullOrEmpty(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Въведете номер на животно за редактиране!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtId.BackColor = Color.LightPink;
                txtId.Focus();
                return;
            }

            findId = int.Parse(txtId.Text);

            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtDescription.Text) ||
                string.IsNullOrEmpty(txtAge.Text))
            {
                Animal findedAnimal = animalController.Get(findId);

                if (findedAnimal == null)
                {
                    MessageBox.Show(
                        "Няма животно с такъв номер!",
                        "Няма запис",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtId.BackColor = Color.LightPink;
                    txtId.Focus();
                    return;
                }

                LoadRecord(findedAnimal);

                MessageBox.Show(
                    "Записът е зареден. Променете данните и натиснете отново 'Редактирай'.",
                    "Редактиране",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            Animal updatedAnimal = new Animal();

            updatedAnimal.Name = txtName.Text;
            updatedAnimal.Description = txtDescription.Text;
            updatedAnimal.Age = int.Parse(txtAge.Text);
            updatedAnimal.BreedID = (int)cmbBreed.SelectedValue;

            animalController.Update(findId, updatedAnimal);

            MessageBox.Show(
                "Записът е редактиран успешно!",
                "Успешно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearScreen();
            ShowAllAnimals();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int findId = 0;

            if (string.IsNullOrEmpty(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Въведете номер на животно за изтриване!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtId.BackColor = Color.LightPink;
                txtId.Focus();
                return;
            }

            findId = int.Parse(txtId.Text);

            Animal findedAnimal = animalController.Get(findId);

            if (findedAnimal == null)
            {
                MessageBox.Show(
                    "Няма животно с такъв номер!",
                    "Няма запис",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtId.BackColor = Color.LightPink;
                txtId.Focus();
                return;
            }

            LoadRecord(findedAnimal);

            DialogResult answer = MessageBox.Show(
                "Сигурни ли сте, че искате да изтриете запис № " + findId + "?",
                "Изтриване",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                animalController.Delete(findId);

                MessageBox.Show(
                    "Записът е изтрит успешно!",
                    "Успешно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearScreen();
                ShowAllAnimals();
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            ShowAllAnimals();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbBreed.SelectedValue == null)
            {
                MessageBox.Show(
                    "Изберете порода!",
                    "Липсващи данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int breedId = (int)cmbBreed.SelectedValue;

            List<Animal> filteredAnimals = animalController.GetAll().Where(a => a.BreedID == breedId).OrderBy(a => a.Id).ToList();

            lstAnimals.Items.Clear();

            foreach (Animal item in filteredAnimals)
            {
                lstAnimals.Items.Add($"{item.Id}. {item.Name}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show(
                "Сигурни ли сте, че искате да излезете?",
                "Изход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                allowClose = true;
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (allowClose)
            {
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Сигурни ли сте, че искате да затворите приложението?",
                "Потвърждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}