namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = WingSize;
        }

        //TODO IFlyable
        public double WingSize { get; set; }
    }
}
