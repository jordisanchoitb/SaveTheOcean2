using System;

namespace SaveTheOcean2
{
    public class SeaTurtle : AAnimal
    {
        public SeaTurtle()
        {
            this.Species = ["Tortuga tonta", "Tortuga laúd", "Tortuga verda"];
            this.WeightSpecies = [120.0, 500.0, 90.0];
            this.AnimalNames = ["Donatello", "Leonardo", "Michelangelo", "Raphael", "Shellby"];
            this.NumSpecie = MethodsUtilities.RandomNum(Species.Length);
            this.Name = AnimalNames[MethodsUtilities.RandomNum(AnimalNames.Length)];
            this.Specie = Species[NumSpecie];
            this.Superfamily = "Tortuga marina";
            this.WeightAprox = WeightSpecies[NumSpecie];
            this.GradeAfectation = MethodsUtilities.RandomNum(1,100);
        }
        public override int CalculateNewGradeAfectation(bool heal)
        {
            int x = 15;
            int newgade = ((2 * GradeAfectation + 3) - ((GradeAfectation - 20) * 2) - x);
            return newgade < 0 ? 0 : newgade;
        }
    }
}
