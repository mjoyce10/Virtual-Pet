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
            userPet.Name = Console.ReadLine();
            Console.WriteLine($"What kind of animal is {userPet.Name}?");
            userPet.Species = Console.ReadLine();

            Console.WriteLine($"{userPet.Name} the {userPet.Species}:");
            Console.WriteLine($"Health: {userPet.GetHealth()}");

            Console.ReadLine();
        }
    }
}
