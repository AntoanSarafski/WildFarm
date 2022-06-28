using System;
using System.Collections.Generic;
using WildFarmPolymorphismExercise.Entities.Animals;
using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem with OWL !!!

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

                    string animalType = animalInfo[0];
                    string name = animalInfo[1];
                    double weight = double.Parse(animalInfo[2]);

                    IAnimal animal = null;
                    if (animalType == "Cat" || animalType == "Tiger")
                    {
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];

                        if (animalType == "Cat")
                        {
                            animal = new Cat(name, weight, livingRegion, breed);
                        }
                        else
                        {
                            animal = new Tiger(name, weight, livingRegion, breed);
                        }
                    }

                    else if (animalType == "Owl" || animalType == "Hen")
                    {
                        double wingSize = double.Parse(animalInfo[3]);

                        if (animalType == "Owl")
                        {
                            animal = new Owl(name, weight, wingSize);
                        }
                        else
                        {
                            animal = new Hen(name, weight, wingSize);
                        }
                    }

                    else if (animalType == "Mouse" || animalType == "Dog")
                    {
                        string livingRegion = animalInfo[3];

                        if (animalType == "Mouse")
                        {
                            animal = new Mouse(name, weight, livingRegion);
                        }
                        else
                        {
                            animal = new Dog(name, weight, livingRegion);
                        }
                    }


                    Console.WriteLine(animal.ProduceSound());
                    animals.Add(animal);

                    string foodType = foodInfo[0];
                    int quantity = int.Parse(foodInfo[1]);

                    IFood food = null;

                    if (foodType == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                    }
                    else if (foodType == "Fruit")
                    {
                        food = new Fruit(quantity);
                    }
                    else if (foodType == "Meat")
                    {
                        food = new Meat(quantity);
                    }
                    else
                    {
                        food = new Seeds(quantity);
                    }
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
