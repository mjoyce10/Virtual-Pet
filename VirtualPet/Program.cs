using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Pet userPet = new Pet();

            Console.WriteLine("What is your pet's name?");
            userPet.SetName(Console.ReadLine());
            Console.WriteLine($"What kind of animal is {userPet.GetName()}?");
            userPet.SetSpecies(Console.ReadLine());

            bool playingGame = true;

            while (playingGame)
            {
            Console.WriteLine($"{userPet.GetName()} the {userPet.GetSpecies()}:");
            Console.WriteLine($"Health: {userPet.GetHealth()}");
            Console.WriteLine($"Hunger: {userPet.GetHunger()}");
            Console.WriteLine($"Thirst: {userPet.GetThirst()}");
            Console.WriteLine($"Boredom: {userPet.GetBoredom()}");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine($"1. Feed {userPet.GetName()}.");
            Console.WriteLine($"2. Give {userPet.GetName()} some water.");
            Console.WriteLine($"3. Play with {userPet.GetName()}.");
            Console.WriteLine($"4. Take {userPet.GetName()} to the doctor.");
            Console.WriteLine("5. Do nothing.");
            Console.WriteLine("6. Exit game.");

            string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        userPet.Feed();
                        break;
                    case "2":
                        userPet.Water();
                        break;
                    case "3":
                        userPet.Play();
                        break;
                    case "4":
                        userPet.SeeDoctor();
                        break;
                    case "5":
                        userPet.Tick();
                        break;
                    case "6":
                        playingGame = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
