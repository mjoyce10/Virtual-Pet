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
        public void Feed()
        {
            if (Hunger < 40)
                Console.WriteLine($"{Name} is not hungry.");
            else
            {
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
        {
            if (Health > 70)
                Console.WriteLine($"{Name} is healthy and doesn't need to see their favourite vet.");
            else
            {
                Health += 30;
                Console.WriteLine($"You took {Name} to see their favourite vet!");
            }
        }
        public void CheckHunger()
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
        public void CheckHealth()
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
        public void CheckThirst()
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
    }
}
