using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveTheOcean2.DTOs;

namespace SaveTheOcean2.Persistence.DAO
{
    public interface IAnimalDAO
    {
        Animal GetAnimalById(int id);
        public IEnumerable<Animal> GetAllAnimals();
        void AddAnimal(Animal animal);
        void UpdateAnimal(Animal animal);
        void DeleteAnimal(int id);
    }
}
