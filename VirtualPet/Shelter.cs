using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public List<Pet> ListOfPets = new List<Pet>();
        
        public void CreateNewPet(Pet userPet, Organic organicPet, Robotic roboticPet, Shelter myShelter)
        {
            Console.WriteLine("\nWould you like your pet to be ...");
            Console.WriteLine("1. An organic pet.");
            Console.WriteLine("2. A robotic pet.");
            string petTypeChoice = Console.ReadLine();
            switch (petTypeChoice)
            {
                case "1":
                    organicPet.MakeNewPet();
                    userPet = new Organic(organicPet.GetName(), organicPet.GetSpecies());
                    myShelter.AddPet(userPet);
                    break;
                case "2":
                    roboticPet.MakeNewPet();
                    userPet = new Robotic(roboticPet.GetName(), roboticPet.GetSpecies());
                    myShelter.AddPet(userPet);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }

        public void AddPet(Pet pet)
        {
            ListOfPets.Add(pet);
        }

        public Pet SelectPet()
        {
            int index = 1;

            Console.WriteLine("Please select a pet from the list to interact with:");
            foreach (Pet pet in ListOfPets)
            {
                Console.WriteLine($"{index}. {pet.Name} the {pet.Species}");
                index++;
            }
            int indexSelected = Convert.ToInt32(Console.ReadLine());
            return ListOfPets[indexSelected - 1];
        }
    }
}
