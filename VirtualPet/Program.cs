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

            Console.WriteLine($"{userPet.GetName()} the {userPet.GetSpecies()}:");
            Console.WriteLine($"Health: {userPet.GetHealth()}");
            Console.WriteLine($"Hunger: {userPet.GetHunger()}");
            Console.WriteLine($"Thirst: {userPet.GetThirst()}");
            Console.WriteLine($"Boredom: {userPet.GetBoredom()}");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Feed your pet.");
            Console.WriteLine("2. Give your pet some water.");
            Console.WriteLine("3. Play with your pet.");
            Console.WriteLine("4. Take your pet to the doctor.");
            Console.WriteLine("5. Do nothing.");
        }
    }
}
