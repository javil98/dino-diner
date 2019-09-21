/*Triceritots.cs
 * Author: Jose C. Avila
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// A class that represents a MezzorellaSticks that inherits from the Triceritots class that inherits from the Side class.
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// A variable that represents the size of the side.
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
                        this.Calories = 590;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Constructs an instance of a Triceritots.
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
            this.Ingredients = new List<string> { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
