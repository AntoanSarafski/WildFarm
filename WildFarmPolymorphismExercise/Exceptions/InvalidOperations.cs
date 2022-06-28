using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarmPolymorphismExercise.Entities.Exceptions
{
    public static class InvalidOperations
    {
        public static void ThrowExceptionForInvalidFood(string animalType, string foodType)
        {
            throw new ArgumentException($"{animalType} does not eat {foodType}!");
        }
    }
}
