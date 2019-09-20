using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks: Side
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
                        this.Calories = 720;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        this.Calories = 540;
                        break;
                }
            }
            get
            {
                return size;
            }

       
        }
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
            this.Ingredients = new List<string> { "Cheese Product", "Breading", "Vegatable Oil" };
        }
    }
}
