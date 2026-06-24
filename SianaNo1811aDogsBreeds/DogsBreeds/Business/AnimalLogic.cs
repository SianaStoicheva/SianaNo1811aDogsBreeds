using DogsBreeds.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DogsBreeds.Business
{
    public class AnimalLogic
    {
        private AnimalsContext context = new AnimalsContext();

        public Animal Get(int id)
        {
            Animal animal = context.Animals.Find(id);

            if (animal != null)
            {
                context.Entry(animal).Reference(x => x.Breeds).Load();
            }

            return animal;
        }

        public List<Animal> GetAll()
        {
            return context.Animals.Include(x => x.Breeds).ToList();
        }

        public void Create(Animal animal)
        {
            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public void Update(int id, Animal animal)
        {
            Animal oldAnimal = context.Animals.Find(id);

            if (oldAnimal == null)
            {
                return;
            }

            oldAnimal.Name = animal.Name;
            oldAnimal.Description = animal.Description;
            oldAnimal.Age = animal.Age;
            oldAnimal.BreedID = animal.BreedID;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Animal animal = context.Animals.Find(id);

            if (animal == null)
            {
                return;
            }

            context.Animals.Remove(animal);
            context.SaveChanges();
        }
    }
}
