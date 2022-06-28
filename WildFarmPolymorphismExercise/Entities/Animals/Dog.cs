using System;
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
