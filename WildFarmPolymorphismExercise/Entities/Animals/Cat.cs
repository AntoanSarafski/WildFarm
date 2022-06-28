﻿using System;
using System.Collections.Generic;
using System.Text;

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
    }
}