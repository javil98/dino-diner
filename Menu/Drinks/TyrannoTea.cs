using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    public class TyrannoTea : Drink
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

                switch (size)
                {
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 8;
                        break;

                    case Size.Small:
                        Price = 0.99;
                        Calories = 32;
                        break;
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
                    return new List<string> { "Water", "Tea", "Lemon", "Cane Sugar" };
                }
                else if (this.Lemon)
                {
                    return new List<string> { "Water", "Tea", "Lemon" };
                }
                else if (this.Sweet)
                {
                    this.Calories *= 2;
                    return new List<string> { "Water", "Tea", "Sugar" };
                }
                else
                {
                    return new List<string> { "Water", "Tea" };
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
