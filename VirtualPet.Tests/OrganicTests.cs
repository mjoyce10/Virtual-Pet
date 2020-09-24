using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicTests
    {
        private Organic organicPet;

        public OrganicTests()
        {
            organicPet = new Organic();
        }

        [Fact]
        public void Pet_Should_Have_Hunger()
        {
            organicPet.Hunger = 100;

            Assert.Equal(100, organicPet.Hunger);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int organicPetHunger = organicPet.GetHunger();

            Assert.Equal(50, organicPetHunger);
        }

        [Fact]
        public void Pet_Should_Have_Health()
        {
            organicPet.Health = 100;

            Assert.Equal(100, organicPet.Health);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
            int organicPetHealth = organicPet.GetHealth();

            Assert.Equal(30, organicPetHealth);
        }

        [Fact]
        public void Feed_Should_Decrease_Hunger_By_40()
        {
            organicPet.Feed();

            Assert.Equal(10, organicPet.GetHunger());
        }

        [Fact]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
            organicPet.SeeDoctor();

            Assert.Equal(60, organicPet.GetHealth());
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            organicPet.Play();

            Assert.Equal(60, organicPet.GetHunger());
        }
        
        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            organicPet.Play();

            Assert.Equal(40, organicPet.GetHealth());
        }
        [Fact]
        public void Play_Should_Increase_Thirst_By_10()
        {
            organicPet.Play();
            Assert.Equal(60, organicPet.GetThirst());
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            organicPet.Tick();

            Assert.Equal(55, organicPet.GetHunger());
        }
        [Fact]
        public void Tick_Should_Decrease_Health_By_5()
        {
            organicPet.Tick();

            Assert.Equal(25, organicPet.GetHealth());
        }
        [Fact]
        public void Tick_Should_Increase_Thirst_By_5()
        {
            organicPet.Tick();

            Assert.Equal(55, organicPet.GetThirst());
        }

        [Fact]
        public void Pet_Should_Have_Thirst()
        {
            organicPet.Thirst = 100;

            Assert.Equal(100, organicPet.Thirst);
        }

        [Fact]
        public void GetThirst_Should_Return_Initial_Thirst_Level_Of_50()
        {
            int organicPetThirst = organicPet.GetThirst();

            Assert.Equal(50, organicPetThirst);
        }
        [Fact]
        public void Water_Should_Decrease_Thirst()
        {
            organicPet.Water();

            Assert.Equal(10, organicPet.GetThirst());
        }
    }
}
