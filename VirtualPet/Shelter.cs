using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public List<Pet> ListOfPets = new List<Pet>();
        
        public void AddPet(Pet pet)
        {
            ListOfPets.Add(pet);
        }
    }
}
