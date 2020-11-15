using Exercise01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise01
{
    public class PetStore<T> where T : Pet
    {
        public List<T> ListOfPets { get; set; } = new List<T>();
        //public List<T> ListOfPets = new List<T>();

        public void AddPetsToStore(T pet)
        {
            ListOfPets.Add(pet);
        }


        public void PrintPets()
        {
            foreach (T item in ListOfPets)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void BuyPet(string name)
        {
            T foundPet = ListOfPets.FirstOrDefault(pet => pet.Name == name);
            if (foundPet == null)
            {
                Console.WriteLine($"There is no pet by the name of {name}");
            }
            else
            {
                ListOfPets.Remove(foundPet);
                Console.WriteLine($"The pet with name {name} was found and removed from the pet store!");
            }
        }


    }
}
