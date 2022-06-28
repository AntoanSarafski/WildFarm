using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
