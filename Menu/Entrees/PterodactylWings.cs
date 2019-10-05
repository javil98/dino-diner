﻿/*PterodactylWings.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing PterodactylWings.
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// Constructs an instance of PterodactlyWings.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
        /// <summary>
        /// Gets a list of ingedients of a Pterodactyl object.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken" };
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
