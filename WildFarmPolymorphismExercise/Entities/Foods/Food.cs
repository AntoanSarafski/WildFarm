using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarmPolymorphismExercise
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; }
    }
}
