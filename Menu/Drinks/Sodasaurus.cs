﻿/*
 * Sodasaurus.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
            Size = Size.Small;
            Price = 1.50;
            Calories = 112;

        }
        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size + " ");
            sb.Append(Flavor + " ");
            sb.Append("Sodasaurus");
            return sb.ToString();
        }

    }
}
