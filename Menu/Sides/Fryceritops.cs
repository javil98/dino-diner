/*Fryceritops.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a Fryceritops which inherits from the Side class.
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// A variable that stores the size of the Side.
        /// </summary>
        protected Size size;
        /// <summary>
        /// A property that sets the size of the side and the price and calories based on the size of the instance. It gets the Size of the side.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Potato", "Salt", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// Constructs an instance of a Fryceritops.
        /// </summary>
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
        }

        public override string ToString()
        {
            return (Size + " Friceritops");
        }

    }
}
