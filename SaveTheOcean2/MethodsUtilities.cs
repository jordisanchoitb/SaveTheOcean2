using System;
using SaveTheOcean2.DTOs;
using Npgsql;
using SaveTheOcean2.Persistence.Utils;
using SaveTheOcean2.Persistence.Mapping;

namespace SaveTheOcean2
{
    public static class MethodsUtilities
    {
        /// <summary>
        /// Retorna un booleà indicant si el número usuari està entre min i max (inclosos)
        /// </summary>
        /// <param name="usernumber">Numero introduit per l'usuari</param>
        /// <param name="min">Num min per verificar (inclos)</param>
        /// <param name="max">Num max per verificar (inclos)</param>
        /// <returns></returns>
        public static bool ValidateOption(int usernumber, int min, int max)
        {
            return usernumber >= min && usernumber <= max;
        }


        /// <summary>
        /// Retorna un número aleatori entre min (inclos) i max (excloit)
        /// </summary>
        /// <param name="min">Numero minimo entero</param>
        /// <param name="max">Numero maximo entero</param>
        /// <returns>int</returns>
        public static int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        /// <summary>
        /// Retorna un booleà indicant si el text comença amb números
        /// </summary>
        /// <param name="text">text</param>
        /// <returns>bool</returns>
        public static bool StartWithNumbers(string text)
        {
            return char.IsDigit(text[0]);
        }


        /// <summary>
        /// Retorna un número aleatori entre 0 i max (excloit)
        /// </summary>
        /// <param name="max">Numero Entero</param>
        /// <returns>int</returns>
        public static int RandomNum(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }

        /// <summary>
        /// Retorna el nom d'una superfamilia aleatoria
        /// </summary>
        /// <returns>string</returns>
        private static string GetRandomSuperfamily()
        {
            string[] superfamily = { "Tortuga marina", "Au marina", "Cetaceo" };
            int index = RandomNum(superfamily.Length);
            return superfamily[index];
        }

        /// <summary>
        /// Retorna l'instància d'un Animal
        /// </summary>
        /// <returns>Animal</returns>
        public static Animal? GetAnimal()
        {
            AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            List<Animal> animals = animalDAO.GetAllAnimals().ToList();
            string superfamily = GetRandomSuperfamily();
            switch (superfamily)
            {
                case "Tortuga marina":
                    List<Animal> filteredSeaTurtle = animals.Where(a => a.Superfamily == "Tortuga marina").ToList();
                    return filteredSeaTurtle[RandomNum(filteredSeaTurtle.Count)];
                case "Au marina":
                    List<Animal> filteredSeaBird = animals.Where(a => a.Superfamily == "Au marina").ToList();
                    return filteredSeaBird[RandomNum(filteredSeaBird.Count)];
                case "Cetaceo":
                    List<Animal> filteredCetaceans = animals.Where(a => a.Superfamily == "Cetáceo").ToList();
                    return filteredCetaceans[RandomNum(filteredCetaceans.Count)];
                default:
                    return null;
            }
        }
    }
}
