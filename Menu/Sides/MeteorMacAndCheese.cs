/*/*MeteorMacAndCheese.cs
 * Author: Jose C. Avila
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// A class that represents a MeteorMacAndCheese that inherits from the Side class.
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// A Size variable that stores the size of the side.
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
                        this.Calories = 520;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                   
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Constructs an instance of a MeteorMacAndCheese.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
            this.Ingredients = new List<string> { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
        }
    }
}
