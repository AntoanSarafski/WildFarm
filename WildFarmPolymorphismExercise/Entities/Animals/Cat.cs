using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }


        public override string ProduceSound()
            => "Meow";
        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Meat)
            {
                // eat
            }
        }
    }
}
