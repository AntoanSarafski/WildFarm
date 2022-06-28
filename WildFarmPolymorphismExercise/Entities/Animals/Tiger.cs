using System;
using WildFarmPolymorphismExercise.Entities.Exceptions;
using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Tiger : Feline
    {
        private const double Modifier = 1;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }


        public override string ProduceSound()
            => "ROAR!!!";
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
