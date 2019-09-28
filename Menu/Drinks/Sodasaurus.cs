/*
 * Sodasaurus.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// An enum that is used to represent the available flavors for Sodasaurus.
    /// </summary>
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
    /// <summary>
    /// A class that represents a Sodasaurus that inherits from the base class of Drink.
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// A property that gets and set the flavor of a Soda.
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; } = SodasaurusFlavor.Cola;

        private Size size;
        /// <summary>
        /// Gets the size, and sets the size, and the price and calories depending on the size of the item.
        /// </summary>
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
        /// <summary>
        /// Gets and sets the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }
        /// <summary>
        /// Creates an instance of a SodaSaurus.
        /// </summary>
        public Sodasaurus()
        {
            this.size = Size.Small;
            this.Price = 1.50;
            this.Calories = 112;

        }

    }
}
