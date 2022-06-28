using System;
using WildFarmPolymorphismExercise.Entities.Exceptions;
using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Dog : Mammal
    {
        private const double Modifier = 0.3;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }


        public override string ProduceSound()
            => "Woof!";
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
