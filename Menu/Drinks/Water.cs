using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class Water : Drink
    {
        public bool Lemon { get; set; } = false;

        public override List<string> Ingredients
        {
                get => new List<string> { "Water" };
        }

        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
        }

        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
