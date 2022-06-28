using System;
using System.Collections.Generic;
using System.Text;
using WildFarmPolymorphismExercise.Entities.Animals;

namespace WildFarmPolymorphismExercise.Factories
{
    public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(
            string[] animalInfo)
        {
            IAnimal animal = null;
            string animalType = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

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
            return animal;
        }
    }
}
