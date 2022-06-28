namespace WildFarmPolymorphismExercise
{
    public interface IAnimal
    {
        public string Name { get; }

        public double Weight { get; }

        public int FoodEaten { get; }

        public string ProduceSound();

        void Eat(IFood food);
    }
}
