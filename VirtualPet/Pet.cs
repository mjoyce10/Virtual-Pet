using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public int Hunger = 50;

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetSpecies()
        {
            return Species;
        }
        public int GetHunger()
        {
            return Hunger;
        }
    }
}
