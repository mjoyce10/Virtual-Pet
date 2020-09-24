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
    }
}
