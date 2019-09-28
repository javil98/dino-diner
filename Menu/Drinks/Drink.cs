/*
 * Drink.cs
 * Author: Nathan Bean
 * Modified by: Jose C. Avila
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{

    /// <summary>
    /// A class that represents a Drink, which is a used as a base class for the rest of the drinks in the project.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets and sets the Size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets and sets Ice
        /// </summary>
        public bool Ice { get; protected set; } = true;

        /// <summary>
        /// Gets and sets Price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the Calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets and set the Ingredients
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Sets the boolean value of Ice to false
        /// </summary>
        public void holdIce()
        {
            Ice = false;
        }

    }
}
