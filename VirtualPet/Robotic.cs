using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robotic : Pet
    {
        public int OilLevel { get; set; } = 50;
        public int PerformanceLevel { get; set; } = 30;

        public int GetOilLevel()
        {
            return OilLevel;
        }

        public int GetPerformanceLevel()
        {
            return PerformanceLevel;
        }
   
        public override void SeeDoctor()
        {
            if (PerformanceLevel > 70)
                Console.WriteLine($"{Name} is functioning optimally and doesn't need to see their favourite mechanical vet.");
            else
            {
                PerformanceLevel += 30;
                Console.WriteLine($"You took {Name} to see their favourite mechanical vet!");
            }
        }
        public override void QuenchThirst()
        {
            if (OilLevel > 60)
                Console.WriteLine($"{Name} does not need oil.");
            else
            {
                OilLevel += 40;
                Console.WriteLine($"You lubricated {Name}.");
            }
        }
        public override void CheckHealth()
        {
            if (PerformanceLevel <= 0)
            {
                Console.WriteLine($"{Name} died because you did not take them to the mechanical vet.");
                StartOver();
                MakeNewPet();
                NewPetStats();
            }
            else if (PerformanceLevel == 5)
                Console.WriteLine($"Get {Name} to the mechanical vet.");
            else if (PerformanceLevel < 20)
                Console.WriteLine($"{Name} is not performing optimally. You should take them to the mechanical vet.");
        }
        public override void CheckThirst()
        {
            if (OilLevel <= 0)
            {
                Console.WriteLine($"{Name} rusted out because you didn't give them oil. You monster.");
                StartOver();
                MakeNewPet();
                NewPetStats();
            }
            else if (OilLevel == 5)
            {
                Console.WriteLine($"Give {Name} some oil!");
            }
            else if (OilLevel < 20)
                Console.WriteLine($"{Name} is very creaky. You should give them some oil.");
        }
        public override void Play()
        {
            base.Play();
            PerformanceLevel += 10;
            OilLevel -= 10;
        }
        public override void Tick()
        {
            base.Tick();
            PerformanceLevel -= 5;
            OilLevel -= 5;
        }

        public override void GiveStats()
        {
            Console.WriteLine($"{GetName()} the {GetSpecies()}:");
            Console.WriteLine($"Performance Level: {GetPerformanceLevel()}");
            Console.WriteLine($"Oil Level: {GetOilLevel()}");
            Console.WriteLine($"Boredom: {GetBoredom()}");
            Console.WriteLine();

        }
        public override void MenuOptions()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine($"1. Oil {GetName()}.");
            Console.WriteLine($"2. Play with {GetName()}.");
            Console.WriteLine($"3. Take {GetName()} to the mechanical vet.");
            Console.WriteLine("4. Do nothing.");
            Console.WriteLine("5. Exit game.");
        }
    }
}
