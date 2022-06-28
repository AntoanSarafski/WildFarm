using System;
using WildFarmPolymorphismExercise.Entities.Exceptions;
using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Mouse : Mammal
    {
        private const double Modifier = 0.1;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }


        public override string ProduceSound()
            => "Squeak";
        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Fruit)
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
