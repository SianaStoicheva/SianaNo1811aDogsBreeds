using System.Windows.Forms;

namespace DogsBreeds
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblDanni = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.picDog = new System.Windows.Forms.PictureBox();
            this.lbllist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanni
            // 
            this.lblDanni.AutoSize = true;
            this.lblDanni.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanni.Location = new System.Drawing.Point(35, 24);
            this.lblDanni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanni.Name = "lblDanni";
            this.lblDanni.Size = new System.Drawing.Size(153, 17);
            this.lblDanni.TabIndex = 0;
            this.lblDanni.Text = "Данни за животното";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(41, 75);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(48, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Номер:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 121);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Име:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(41, 174);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Описание:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(41, 282);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(55, 15);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Възраст:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(41, 329);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(53, 15);
            this.lblBreed.TabIndex = 5;
            this.lblBreed.Text = "Порода:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(151, 71);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(210, 21);
            this.txtId.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 118);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(151, 168);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(385, 92);
            this.txtDescription.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(151, 280);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(210, 21);
            this.txtAge.TabIndex = 9;
            // 
            // cmbBreed
            // 
            this.cmbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Location = new System.Drawing.Point(151, 326);
            this.cmbBreed.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(210, 23);
            this.cmbBreed.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAdd.Location = new System.Drawing.Point(41, 406);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(199, 406);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 41);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Редактирай";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Location = new System.Drawing.Point(356, 406);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 41);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFind.BackColor = System.Drawing.SystemColors.Window;
            this.btnFind.Location = new System.Drawing.Point(41, 468);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(134, 41);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Намери";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSelectAll.Location = new System.Drawing.Point(199, 468);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(134, 41);
            this.btnSelectAll.TabIndex = 15;
            this.btnSelectAll.Text = "Покажи всички";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilter.BackColor = System.Drawing.SystemColors.Window;
            this.btnFilter.Location = new System.Drawing.Point(356, 468);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(134, 41);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.Text = "Филтрирай";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClear.Location = new System.Drawing.Point(122, 527);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 41);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(284, 527);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 41);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstAnimals
            // 
            this.lstAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.HorizontalExtent = 1000;
            this.lstAnimals.HorizontalScrollbar = true;
            this.lstAnimals.ItemHeight = 15;
            this.lstAnimals.Location = new System.Drawing.Point(525, 295);
            this.lstAnimals.Margin = new System.Windows.Forms.Padding(4);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(407, 274);
            this.lstAnimals.TabIndex = 21;
            // 
            // picDog
            // 
            this.picDog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDog.Image = global::DogsBreeds.Properties.Resources.large_6393293312a0bacfdac214ba_b6b82e5285e94222cdb70fb28dfe9183a948c430d9e15311bce3091c72383cc0_639329dd1;
            this.picDog.Location = new System.Drawing.Point(626, 34);
            this.picDog.Margin = new System.Windows.Forms.Padding(4);
            this.picDog.Name = "picDog";
            this.picDog.Size = new System.Drawing.Size(292, 188);
            this.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDog.TabIndex = 22;
            this.picDog.TabStop = false;
            // 
            // lbllist
            // 
            this.lbllist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllist.AutoSize = true;
            this.lbllist.Location = new System.Drawing.Point(557, 266);
            this.lbllist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(110, 15);
            this.lbllist.TabIndex = 23;
            this.lbllist.Text = "Списък с животни";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(973, 581);
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.picDog);
            this.Controls.Add(this.lblDanni);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cmbBreed);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstAnimals);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(989, 607);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приют за кучета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanni;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBreed;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbBreed;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.ListBox lstAnimals;
        private System.Windows.Forms.PictureBox picDog;
        private System.Windows.Forms.Label lbllist;
    }
}