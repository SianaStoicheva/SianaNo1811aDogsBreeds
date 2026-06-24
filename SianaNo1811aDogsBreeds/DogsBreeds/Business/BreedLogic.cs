using DogsBreeds.Models;
using System.Collections.Generic;
using System.Linq;

namespace DogsBreeds.Business
{
    public class BreedLogic
    {
        private AnimalsContext context = new AnimalsContext();

        public List<Breed> GetAllBreeds()
        {
            return context.Breeds.ToList();
        }

        public string GetBreedById(int id)
        {
            return context.Breeds.Find(id).Name;
        }
    }
}
