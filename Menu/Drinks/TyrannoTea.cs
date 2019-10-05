/*
 *TyrannoTea.cs 
 * Author: Jose C. Avila
 */

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a TyrannoTea which inherits from the Drink base class.
    /// </summary>
    public class TyrannoTea : Drink
    {
        /// <summary>
        /// Gets and sets Sweet
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// Gets and sets Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        private Size size;
        /// <summary>
        /// Gets the siz, and sets the calories and Price depening on the set size.
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
                        Price = 1.99;
                        if (Sweet == false) { Calories = 32; }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet == false) { Calories = 16; }
                        break;

                    case Size.Small:
                        Price = 0.99;
                        if (Sweet == false) { Calories = 8; }
                        break;
                }
            }

        }
        /// <summary>
        /// Gets and sets the Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Lemon && Sweet)
                {
                    return new List<string> { "Water", "Tea", "Lemon", "Cane Sugar" };
                }
                else if (Lemon)
                {
                    return new List<string> { "Water", "Tea", "Lemon" };
                }
                else if (Sweet)
                {
                    return new List<string> { "Water", "Tea", "Cane Sugar" };
                }
                else
                {
                    return new List<string> { "Water", "Tea" };
                }
            }
        }

        /// <summary>
        /// Creates an instance of a TyrannoTea.
        /// </summary>
        public TyrannoTea()
        {
            Price = 0.99;
            Size = Size.Small;
            Calories = 8;
        }
        /// <summary>
        /// Sets Lemon to true.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        public void AddSweet()
        {
            Sweet = true;
            Calories = Calories * 2;
        }
        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return Size + " Sweet Tyrannotea";
            }
            return Size + " Tyrannotea";
        }
    }
}
