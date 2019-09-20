using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        private Size size;

        public override Size Size
        {
            set
            {
                Size = value;
                switch (size)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        this.Calories = 352;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 420;
            this.Ingredients = new List<string> { "Potatoes", "Salt", "Vegatable Oil" };
        }
    }
}
