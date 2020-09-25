using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Pet userPet = new Pet();
            Organic organicPet = new Organic();
            Robotic roboticPet = new Robotic();
            userPet.MakeNewPet();
            bool playingGame = true;

            while (playingGame)
            {
            Console.Clear();

            string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        organicPet.Feed();
                        break;
                    case "2":
                        organicPet.QuenchThirst();
                        break;
                    case "3":
                        userPet.Play();
                        break;
                    case "4":
                        organicPet.SeeDoctor();
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
                Console.WriteLine();
                organicPet.CheckHealth();
                organicPet.CheckHunger();
                organicPet.CheckThirst();
                userPet.CheckBoredom();
                Console.ReadKey();
            }

            Console.ReadLine();
        }
    }
}
