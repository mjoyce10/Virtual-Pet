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
            myShelter.CreateNewPet(userPet, organicPet, roboticPet, myShelter);

            bool playingGame = true;

            while (playingGame)
            {
            Console.Clear();
            
            foreach (Pet pet in myShelter.ListOfPets)
            {
                pet.GiveStats();
            }

            userPet = myShelter.SelectPet();
            Console.Clear();
            userPet.GiveStats();
            Console.WriteLine();
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
                        Console.Clear();
                        myShelter.CreateNewPet(userPet, organicPet, roboticPet, myShelter);
                        break;
                    case "7":
                        playingGame = false;
                        Console.WriteLine("Thanks for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                
                userPet.Tick();
                userPet.CheckHealth();
                userPet.CheckHunger();
                userPet.CheckThirst();
                userPet.CheckBoredom();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            Console.ReadLine();
        }
    }
}
