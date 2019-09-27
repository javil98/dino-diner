using System;
using System.Collections.Generic;
using System.Text;

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

    public class Sodasaurus: Drink
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
                if(size == Size.Small)
                {
                    this.Calories = 112;
                    this.Price = 1.50;
                }
                if(size == Size.Medium)
                {
                    this.Calories = 156;
                    this.Price = 2.00;
                }
                if(size == Size.Large)
                {
                    this.Calories = 208;
                    this.Price = 2.50;
                }
            }

        }
        public override List<string> Ingredients
        {
            get => new List<string> { "Water", "Natural Flavors", "Cane Sugar" };
        }

        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;

        }
    }
}
