using System;
using WildFarmPolymorphismExercise.Entities.Exceptions;
using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Cat : Feline
    {
        private const double Modifier = 0.3;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }


        public override string ProduceSound()
            => "Meow";
        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Meat)
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
