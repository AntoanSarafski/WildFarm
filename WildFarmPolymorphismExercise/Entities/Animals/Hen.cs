namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Hen : Bird
    {
        private const double Modifier = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
            => "Cluck";

        public override void Eat(IFood food)
        {
            this.Weight += food.Quantity * Modifier;
            this.FoodEaten += food.Quantity;
        }

    }
}
