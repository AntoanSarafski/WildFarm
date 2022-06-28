using System;
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
