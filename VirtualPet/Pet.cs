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

        public int Boredom { get; set; } = 60;
        

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
        

        public int GetBoredom()
        {
            return Boredom;
        }
       
        
        public void Play()
        { 
            if (Boredom < 20)
                Console.WriteLine($"{Name} doesn't feel like playing right now.");
            else
            {
                Hunger += 10;
                Boredom -= 20;
                Health += 10;
                Thirst += 10;
                Console.WriteLine($"You played with {Name}!");
            }
        }
        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
            Thirst += 5;
        }

        public void CheckBoredom()
        {
            if (Boredom >= 100)
            {
                Console.WriteLine($"Bad news. {Name} has died of boredom.");
                StartOver();
                MakeNewPet();
                NewPetStats();
            }
            else if (Boredom == 95)
                Console.WriteLine($"PLAY WITH {Name}!!");
            else if (Boredom > 80)
                Console.WriteLine($"{Name} is very bored. You should play with them.");
        }

        public void StartOver()
        {
            Console.WriteLine("Press any key to start over.");
            Console.ReadKey();
            Console.Clear();
        }
        public void MakeNewPet()
        { 
            Console.WriteLine("What is your pet's name?");
            Name = Console.ReadLine();
            Console.WriteLine($"What kind of animal is {Name}?");
            Species = Console.ReadLine();
        }

        public void NewPetStats()
        {
            Boredom = 60;
            Hunger = 50;
            Thirst = 50;
            Health = 30;
        }
    }
}
