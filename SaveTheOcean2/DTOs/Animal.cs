using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.DTOs
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Specie { get; set; }
        public string? Superfamily { get; set; }
        public double WeightAprox { get; set; }
        public int GradeAfectation { get; set; } = MethodsUtilities.RandomNum(1, 100);
        public int CalculateNewGradeAfectation(bool heal) 
        {
            int x, newgrade;
            switch (this.Superfamily)
            {
                case "Tortuga marina":
                    x = 15;
                    newgrade = (int)((2 * GradeAfectation + 3) - ((GradeAfectation - 20) * 2) - x);
                    return newgrade < 0 ? 0 : newgrade;
                case "Au marina":
                    x = heal ? 5 : 0;
                    newgrade = (int)((GradeAfectation - x) / 5);
                    return newgrade < 0 ? 0 : newgrade;
                case "Cetáceo":
                    x = heal ? 50 : 0;
                    newgrade = (int)(this.GradeAfectation - (this.GradeAfectation / 5) - x);
                    return newgrade < 0 ? 0 : newgrade;
                default:
                    return 0;
            }
        }



    }
}
