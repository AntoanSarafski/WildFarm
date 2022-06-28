using System;
using WildFarmPolymorphismExercise.Entities.Exceptions;
using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Owl : Bird
    {
        private const double Modifier = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
            => "Hoot Hoot";

        public override void Eat(IFood food)
        {
            if (food is Meat)
            {
                BaseEat(Modifier, food.Quantity);
            }
            else
            {
                InvalidOperations.ThrowExceptionForInvalidFood(
                    this.GetType().Name, food.GetType().Name);
            }
        }

    }
}
