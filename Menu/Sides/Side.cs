/*Brontowurst.cs
 * Author: Nathan Bean
 * Modified by: Jose C. Avila
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// A enum that represents the available sizes of the sides.
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }
    /// <summary>
    /// A class that represents Sides.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
