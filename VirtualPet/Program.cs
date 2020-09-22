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
                        Console.WriteLine($"You fed {userPet.GetName()}!" );
                        break;
                    case "2":
                        userPet.Water();
                        Console.WriteLine($"You gave {userPet.GetName()} some water!");
                        break;
                    case "3":
                        userPet.Play();
                        Console.WriteLine($"You played with {userPet.GetName()}!" );
                        break;
                    case "4":
                        userPet.SeeDoctor();
                        Console.WriteLine($"You took {userPet.GetName()} to see his favorite vet!");
                        break;
                    case "5":
                        userPet.Tick();
                        Console.WriteLine($"You did nothing. {userPet.GetName()} gives you a soulful look.");
                        break;
                    case "6":
                        playingGame = false;
                        Console.WriteLine("Thanks for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
