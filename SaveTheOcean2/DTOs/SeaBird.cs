﻿using System;

namespace SaveTheOcean2
{
    public class SeaBird : AAnimal
    {
        public SeaBird()
        {
            this.Species = ["Gaviota de audouin", "Pardela cenicienta", "Alcatraz comu", "Cormoran gran"];
            this.WeightSpecies = [0.65, 1.0, 3.0, 4.0];
            this.AnimalNames = ["Albatros", "Marlin", "Oceana", "Skye", "Wave"];
            this.NumSpecie = MethodsUtilities.RandomNum(Species.Length);
            this.Name = AnimalNames[MethodsUtilities.RandomNum(AnimalNames.Length)];
            this.Specie = Species[NumSpecie];
            this.Superfamily = "Au marina";
            this.WeightAprox = WeightSpecies[NumSpecie];
            this.GradeAfectation = MethodsUtilities.RandomNum(1,100);
        }
        public override int CalculateNewGradeAfectation(bool heal)
        {
            int x = heal ? 5 : 0;
            int newgade = (int)((GradeAfectation - x)/5);
            return newgade < 0 ? 0 : newgade;
        }
    }
}
