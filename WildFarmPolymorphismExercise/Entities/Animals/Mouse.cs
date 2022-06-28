using WildFarmPolymorphismExercise.Entities.Foods;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Mouse : Mammal
    {
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
                //eat;
            }
        }
    }
}
