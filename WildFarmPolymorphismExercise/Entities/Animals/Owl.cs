using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarmPolymorphismExercise.Entities.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
            => "Hoot Hoot";
    }
}
