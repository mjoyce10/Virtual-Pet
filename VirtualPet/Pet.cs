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
            if (Hunger < 40)
                Console.WriteLine($"{Name} is not hungry.");
            else {
                Hunger -= 40;
                Console.WriteLine($"You fed {Name}.");
                  }
            
        }
        public void Water()
        {
            if (Thirst < 40)
                Console.WriteLine($"{Name} is not thirsty.");
            else
            {
                Thirst -= 40;
                Console.WriteLine($"You hydrated {Name}.");
            }
        }
        public void SeeDoctor()
        { if (Health > 70)
                Console.WriteLine($"{Name} is healthy and doesn't need to see their favourite vet.");
            else
            {
                Health += 30;
                Console.WriteLine($"You took {Name} to see their favourite vet!");
            }
        }
        public void Play()
        { if (Boredom < 20)
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

            Console.WriteLine();
            if (Health <= 0)
                Console.WriteLine($"{Name} died because you did not take them to the vet.");
            // Go back and create a new pet.
            else if (Health == 5)
                Console.WriteLine($"Get {Name} to the vet.");
            else if (Health < 20)
                Console.WriteLine($"{Name} is not feeling well. You should take them to the vet.");
            if (Hunger >= 100)
            {
                Console.WriteLine($"{Name} died because you didn't feed them!");
                //Go back and create a new pet.
            }
            else if (Hunger == 95)
                Console.WriteLine($"Feed {Name}!");
            else if (Hunger > 80)
                Console.WriteLine($"{Name} is very hungry. You should feed them.");
            if (Thirst >= 100)
            {
                Console.WriteLine($"{Name} died because you didn't give them water.");
                //Go back and create a new pet. 
            }
            else if (Thirst == 95)
            {
                Console.WriteLine($"Give {Name} some water!");
            }
            else if (Thirst > 80)
                Console.WriteLine($"{Name} is very thirsty. You should give them some water.");
            if (Boredom >= 100)
            {
                Console.WriteLine($"Bad news. {Name} has died of boredom.");
                //Go back and create a new pet.

            }
            else if (Boredom == 95)
                Console.WriteLine($"PLAY WITH {Name}!!");
            else if (Boredom > 80)
                Console.WriteLine($"{Name} is very bored. You should play with them.");
            

        }
    }
}
