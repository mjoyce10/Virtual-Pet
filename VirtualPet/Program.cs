using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Pet userPet = new Pet();
            Shelter myShelter = new Shelter();
            Organic organicPet = new Organic();
            Robotic roboticPet = new Robotic();
            Console.WriteLine("Would you like your pet to be ...");
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

            
            bool playingGame = true;

            while (playingGame)
            {
            Console.Clear();
            
            foreach (Pet pet in myShelter.ListOfPets)
            {
                pet.GiveStats();
                Console.WriteLine();
                Console.ReadLine();
            }

            userPet = myShelter.SelectPet();
            userPet.MenuOptions();

            string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        userPet.Feed();
                        break;
                    case "2":
                        userPet.QuenchThirst();
                        break;
                    case "3":
                        userPet.Play();
                        break;
                    case "4":
                        userPet.SeeDoctor();
                        break;
                    case "5":
                        Console.WriteLine($"You did nothing.");
                        break;
                    case "6":
                        playingGame = false;
                        Console.WriteLine("Thanks for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                
                userPet.Tick();
                organicPet.CheckHealth();
                organicPet.CheckHunger();
                organicPet.CheckThirst();
                userPet.CheckBoredom();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            Console.ReadLine();
        }
    }
}
