using System;
using SaveTheOcean2.DTOs;
using Npgsql;
using SaveTheOcean2.Persistence.Utils;
using SaveTheOcean2.Persistence.Mapping;

namespace SaveTheOcean2
{
    public static class MethodsUtilities
    {
        const string MSG_INFOLINE = "+-------------------------------------------------------------+";
        const string MSG_INFONAME_RES = "|                       RESCAT                                |";
        const string MSG_INFORES = "| # Rescat | Data rescat | Superfamília   | GA | Localització |";
        const string MSG_INFORES_STATS = "|  {0,-6}  | {1,-10} | {2,-14} | {3,-2} | {4,-12} |";
        const string MSG_INFONAME_SHEET = "|                       FITXA                                 |";
        const string MSG_INFOSHEET = "| # Nom  | Superfamília   | Espècie       | Pes aproximat     |";
        const string MSG_INFOSHEET_STATS = "| {0,-6} | {1,-14} | {2,-8} | {3,-15:F1}kg |";

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


        /// <summary>
        /// Imprimeix per consola les dades del rescat passat per paràmetre
        /// </summary>
        /// <param name="rescued">objecta Rescued</param>
        public static string PrintInfoData(Rescued rescued)
        {
            return $"{MSG_INFOLINE}\n" +
                $"{MSG_INFONAME_RES}\n" +
                $"{MSG_INFOLINE}\n" +
                $"{MSG_INFORES}\n" +
                $"{MSG_INFOLINE}\n" +
                $"{string.Format(MSG_INFORES_STATS, rescued.Number, rescued.Date.ToString("dd/MM/yyyy"), rescued.Superfamily, rescued.Animal.GradeAfectation, rescued.Location)}\n" +
                $"{MSG_INFOLINE}";

        }


        /// <summary>
        /// Imprimeix per consola les dades de la fitxa del rescat passat per paràmetre
        /// </summary>
        /// <param name="rescued">objecta Rescued</param>
        public static string PrintInfoDataSheet(Rescued rescued)
        {
            return $"{MSG_INFOLINE}\n" +
                $"{MSG_INFONAME_SHEET}\n" +
                $"{MSG_INFOLINE}\n" +
                $"{MSG_INFOSHEET}\n" +
                $"{MSG_INFOLINE}\n" +
                $"{string.Format(MSG_INFOSHEET_STATS, rescued.Animal.Name, rescued.Animal.Superfamily, rescued.Animal.Specie, rescued.Animal.WeightAprox)}\n" +
                $"{MSG_INFOLINE}";
        }
    }
}
