namespace WildFarmPolymorphismExercise
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get;  }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract string ProduceSound();

        public abstract void Eat(IFood food);

        protected void BaseEat(double modifier, int quantity)
        {
            this.Weight += quantity * modifier;
            this.FoodEaten += quantity;
        }
        
    }
}
