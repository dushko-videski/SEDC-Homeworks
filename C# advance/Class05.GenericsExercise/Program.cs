using Exercise01.Entities;
using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {

            PetStore<Dog> DogStore = new PetStore<Dog>();
            PetStore<Cat> CatStore = new PetStore<Cat>();
            PetStore<Fish> FishStore = new PetStore<Fish>();

            DogStore.AddPetsToStore(new Dog() { Name = "Sharko", Age = 5, FavouriteFood = "meat",
                GoodBoi = true, Type = "Labrador"});
            DogStore.AddPetsToStore(new Dog() { Name = "Blacky", Age = 2, FavouriteFood = "PedegreePall", GoodBoi = true, Type = "Hasky"});


            CatStore.AddPetsToStore(new Cat() { Name = "Flufy", Age = 1, Lazy = true, LivesLeft = 5, Type = "Persian" });
            CatStore.AddPetsToStore(new Cat() { Name = "Tom", Age = 70, Lazy = false, LivesLeft = 1, Type = "CartoonCat" });

            FishStore.AddPetsToStore(new Fish("Grey", 3.5, "Cleo", "Throut", 9));
            FishStore.AddPetsToStore(new Fish("Yellow and White", 0.5, "Nemo", "seafish", 1));

            DogStore.BuyPet("Sharko");
            CatStore.BuyPet("Meow");
            Console.WriteLine("---------------------");
            DogStore.PrintPets();
            CatStore.PrintPets();
            FishStore.PrintPets();



            Console.ReadLine();
        }
    }
}
