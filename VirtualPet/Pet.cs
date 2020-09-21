using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public int Boredom = 60;
        public int Hunger = 50;
        public int Health = 30;
        public int Thirst = 50;


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

        public int GetBoredom()
        {
            return Boredom;
        }
        public int GetHealth()
        {
            return Health;
        }
        public int GetThirst()
        {
            return Thirst;
        }
        public void Feed()
        {
            Hunger -= 40;
        }
        public void SeeDoctor()
        {
            Health += 30;
        }
        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }
        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }
    }
}
