using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class TyrannoTea: Drink
    {
        public bool Sweet { get; set; } = false;

        public bool Lemon { get; set; } = false;

        private Size size;
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    this.Calories = 8;
                    this.Price = 0.99;
                }
                if (size == Size.Medium)
                {
                    this.Calories = 16;
                    this.Price = 1.49;
                }
                if (size == Size.Large)
                {
                    this.Calories = 32;
                    this.Price = 1.99;
                }
            }

        }

        public override List<string> Ingredients
        {
            get
            {
                if (this.Lemon && this.Sweet)
                {
                    this.Calories *= 2;
                    return new List<string> { "Water", "Tea",  "Lemon", "Cane Sugar" };
                }
                else if (this.Lemon)
                {
                    return new List<string> { "Water", "Tea",  "Lemon" };
                }
                else if (this.Sweet)
                {
                    this.Calories *= 2;
                    return new List<string> { "Water", "Tea", "Sugar" };
                }
                else
                {
                    return new List<string> { "Water" , "Tea" };
                }
            }
        }

        public TyrannoTea()
        {
            this.Price = 0.99;
            this.Calories = 8; 
        }

        public void AddLemon()
        {
            this.Lemon = false;
        }

    }
}
