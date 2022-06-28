using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Dog : Mammal
    {
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
                // eat
            }
        }
    }
}
