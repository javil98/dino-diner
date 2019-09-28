using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }

    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }
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
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;

                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }

            }
        }
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        public Sodasaurus()
        {
            this.size = Size.Small;
            this.Price = 1.50;
            this.Calories = 112;

        }

    }
}
