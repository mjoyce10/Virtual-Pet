using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RoboticTests
    {
        private Robotic roboticPet;

        public RoboticTests()
        {
            roboticPet = new Robotic();
        }

        [Fact]
        public void Pet_Should_Have_OilLevel()
        {
            roboticPet.OilLevel = 100;

            Assert.Equal(100, roboticPet.OilLevel);
        }
        
        [Fact]
        public void GetOilLevel_Should_Return_Initial_Oil_Level_Of_50()
        {
            int roboticPetOilLevel = roboticPet.GetOilLevel();

            Assert.Equal(50, roboticPetOilLevel);
        }
        
        [Fact]
        public void Pet_Should_Have_PerformanceLevel()
        {
            roboticPet.PerformanceLevel = 100;

            Assert.Equal(100, roboticPet.PerformanceLevel);
        }

        [Fact]
        public void GetPerformanceLevel_Should_Return_Initial_PerformanceLevel_Of_30()
        {
            int roboticPetPerformanceLevel = roboticPet.GetPerformanceLevel();

            Assert.Equal(30, roboticPetPerformanceLevel);
        }
    }
}
