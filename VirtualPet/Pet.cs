using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public int Boredom { get; set; } = 60;


        public void SetName(string name)
        {
            Name = name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetSpecies()
        {
            return Species;
        }


        public int GetBoredom()
        {
            return Boredom;
        }


        public virtual void Play()
        {
            Boredom -= 20;

            Console.WriteLine($"You played with {Name}!");
        }
        public virtual void Tick()
        {
            Boredom += 5;

        }
        public virtual void CheckHealth()
        {

        }

        public virtual void CheckThirst()
        {

        }
        public virtual void CheckHunger()
        {

        }
        public void CheckBoredom()
        {
            if (Boredom >= 100)
            {
                Console.WriteLine($"Bad news. {Name} has died of boredom.");
                StartOver();
                MakeNewPet();
                NewPetStats();
            }
            else if (Boredom == 95)
                Console.WriteLine($"PLAY WITH {Name}!!");
            else if (Boredom > 80)
                Console.WriteLine($"{Name} is very bored. You should play with them.");
        }

        public virtual void SeeDoctor()
        {

        }
        public virtual void Feed()
        {

        }
        public virtual void QuenchThirst()
        {

        }
        public void StartOver()
        {
            Console.WriteLine("Press any key to start over.");
            Console.ReadKey();
            Console.Clear();
        }
        public virtual void MakeNewPet()
        { 
            Console.WriteLine("What is your pet's name?");
            Name = Console.ReadLine();
            Console.WriteLine($"What kind of animal is {Name}?");
            Species = Console.ReadLine();
        }

        public virtual void NewPetStats()
        {
            Boredom = 60;
            
        }
        public virtual void GiveStats()
        {

        }
        public virtual void MenuOptions()
        {

        }
        public void Adopted() 
        {
            
        }

    }
}
