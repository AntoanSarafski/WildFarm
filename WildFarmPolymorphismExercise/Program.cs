using System;
using System.Collections.Generic;
using WildFarmPolymorphismExercise.Entities.Animals;
using WildFarmPolymorphismExercise.Entities.Foods;
using WildFarmPolymorphismExercise.Factories;

namespace WildFarmPolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem with OWL WINGSIZE !!!

            string input = Console.ReadLine();

            List<IAnimal> animals = new List<IAnimal>();

            while (input != "End")
            {
                //  •	Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}"
                //  •	Birds - "{Type} {Name} {Weight} {WingSize}"
                //  •	Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}"

                try
                {
                    string[] animalInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string[] foodInfo = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    IAnimal animal = AnimalFactory.CreateAnimal(animalInfo);
                    IFood food = FoodFactory.CreateFood(foodInfo);
                    
                    Console.WriteLine(animal.ProduceSound());
                    animals.Add(animal);
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
