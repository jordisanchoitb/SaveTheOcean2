using System;

namespace SaveTheOcean2.DTOs
{
    public class Rescued
    {
        public string? Number { get; set; }
        public DateTime Date { get; set; }
        public string? Superfamily { get; set; }
        public Animal Animal { get; set; }
        public string? Location { get; set; }
        public static string[] Locations { get; set; } = { "Mar Mediterráneo", "Mar Rojo", "Mar del Norte", "Mar del Sur", "Mar del est", "Mar del Caribe" };

        public Rescued(Animal animal)
        {
            this.Number = "RES" +  MethodsUtilities.RandomNum(1000).ToString("D3");
            this.Date = DateTime.Now;
            this.Animal = animal;
            this.Superfamily = animal.Superfamily;
            this.Location = Locations[MethodsUtilities.RandomNum(Locations.Length)];
        }
    }
}
