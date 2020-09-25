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
        public void GiveOil()
        {
            OilLevel += 40; 
        }
        public void SeeMechanic()
        {
            PerformanceLevel += 30;
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
    }
}
