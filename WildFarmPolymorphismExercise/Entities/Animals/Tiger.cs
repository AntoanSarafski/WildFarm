using System;
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
                this.Weight += food.Quantity * Modifier;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException(
                    $"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
       
    }
}
