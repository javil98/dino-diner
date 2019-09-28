/*Entree.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class that represents a Entree class that is used as a base class for the sides.
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// A property that represents the Price of an entree.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// A property that represents the calories of an entree.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// A property gets and sets the ingredients of an entree.
        /// </summary>
        public virtual List<string> Ingredients { get; set; }
    }
}
