using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
   public class Organic : Pet
    {
        public int Hunger { get; set; } = 50;
        public int Health { get; set; } = 30;
        public int Thirst { get; set; } = 50;
        public Organic() 
        { 
        
        }
        public Organic(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public int GetHunger()
        {
            return Hunger;
        }
        public int GetHealth()
        {
            return Health;
        }
        public int GetThirst()
        {
            return Thirst;
        }
        public override void Feed()
        {
            if (Hunger < 40)
                Console.WriteLine($"{Name} is not hungry.");
            else
            {
                Hunger -= 40;
                Console.WriteLine($"You fed {Name}.");
            }

        }
        public override void QuenchThirst()
        {
            if (Thirst < 40)
                Console.WriteLine($"{Name} is not thirsty.");
            else
            {
                Thirst -= 40;
                Console.WriteLine($"You hydrated {Name}.");
            }
        }
        public override void SeeDoctor()
        {
            if (Health > 70)
                Console.WriteLine($"{Name} is healthy and doesn't need to see their favourite vet.");
            else
            {
                Health += 30;
                Console.WriteLine($"You took {Name} to see their favourite vet!");
            }
        }
        public override void CheckHunger()
        {
            if (Hunger >= 100)
            {
                Console.WriteLine($"{Name} died because you didn't feed them!");
                StartOver();
                MakeNewPet();
                NewPetStats();
            }
            else if (Hunger == 95)
                Console.WriteLine($"Feed {Name}!");
            else if (Hunger > 80)
                Console.WriteLine($"{Name} is very hungry. You should feed them.");
        }
        public override void CheckHealth()
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} died because you did not take them to the vet.");
                StartOver();
                MakeNewPet();
                NewPetStats();
            }
            else if (Health == 5)
                Console.WriteLine($"Get {Name} to the vet.");
            else if (Health < 20)
                Console.WriteLine($"{Name} is not feeling well. You should take them to the vet.");
        }
        public override void CheckThirst()
        {
            if (Thirst >= 100)
            {
                Console.WriteLine($"{Name} died because you didn't give them water.");
                StartOver();
                MakeNewPet();
                NewPetStats();
            }
            else if (Thirst == 95)
            {
                Console.WriteLine($"Give {Name} some water!");
            }
            else if (Thirst > 80)
                Console.WriteLine($"{Name} is very thirsty. You should give them some water.");
        }
        public override void Play()
        {
            base.Play();
            Hunger += 10;
            Health += 10;
            Thirst += 10;
        }
        public override void Tick()
        {
            base.Tick();
            Hunger += 5;
            Health -= 5;
            Thirst += 5;
        }
        
        public override void NewPetStats()
        {
            base.NewPetStats();
            Hunger = 50;
            Health  = 30;
            Thirst = 50;
        }

        public override void GiveStats()
        {
            Console.WriteLine($"{GetName()} the {GetSpecies()}:");
            Console.WriteLine($"Health: {GetHealth()}");
            Console.WriteLine($"Hunger: {GetHunger()}");
            Console.WriteLine($"Thirst: {GetThirst()}");
            Console.WriteLine($"Boredom: {GetBoredom()}");
            Console.WriteLine();

        }
        public override void MenuOptions()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine($"1. Feed {GetName()}.");
            Console.WriteLine($"2. Give {GetName()} some water.");
            Console.WriteLine($"3. Play with {GetName()}.");
            Console.WriteLine($"4. Take {GetName()} to the doctor.");
            Console.WriteLine("5. Do nothing.");
            Console.WriteLine("6. Exit game.");
        }
    }
}
