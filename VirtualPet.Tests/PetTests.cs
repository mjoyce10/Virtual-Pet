using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetTests
    {
        private Pet testPet;


        public PetTests()
        {
            testPet = new Pet();
        }

        [Fact]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(testPet);
        }

        // INSTRUCTIONS:
        // Uncomment code in the test body one test at a time
        // Add source code to eliminate the build errors (red squiggle) and pass the test

        [Fact]
        public void Pet_Should_Have_Name()
        {
            testPet.Name = "Pet Name";

            Assert.Equal("Pet Name", testPet.Name);
        }

        [Fact]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
            testPet.SetName("Fluffy");

            Assert.Equal("Fluffy", testPet.Name);
        }

        [Fact]
        public void GetName_Should_Get_Pet_Name_Value()
        {
            testPet.SetName("Fido");

            string testPetName = testPet.GetName();

            Assert.Equal("Fido", testPetName);
        }

        [Fact]
        public void Pet_Should_Have_Species()
        {
            testPet.Species = "Pet Species";

            Assert.Equal("Pet Species", testPet.Species);
        }

        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            testPet.SetSpecies("Cat");

            Assert.Equal("Cat", testPet.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            testPet.SetSpecies("Dog");

            string testPetSpecies = testPet.GetSpecies();

            Assert.Equal("Dog", testPetSpecies);
        }

        [Fact]
        public void Pet_Should_Have_Boredom()
        {
            {
                testPet.Boredom = 100;

                Assert.Equal(100, testPet.Boredom);
            }
        }

        [Fact]
        public void GetBoredom_Should_Return_Initial_Boredom_Level_Of_60()
        {
            int testPetBoredom = testPet.GetBoredom();

            Assert.Equal(60, testPetBoredom);
        }

        [Fact]
        public void Play_Should_Decrease_Boredom_By_20()
        {
            testPet.Play();

            Assert.Equal(40, testPet.GetBoredom());
        }

        [Fact]
        public void Tick_Should_Increase_Boredom_By_5()
        {
            testPet.Tick();

            Assert.Equal(65, testPet.GetBoredom());
        }
    }
}