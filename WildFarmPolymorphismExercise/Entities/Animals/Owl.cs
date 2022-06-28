using System;
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
