/*
 * Water.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    // A class that represents Water which inherits from the Drink base class.
    public class Water : Drink
    {
        /// <summary>
        /// Gets and sets Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets a list of ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Lemon == false) { return new List<string> { "Water" }; }
                else { return new List<string> { "Water", "Lemon" }; }
            }
             
        }

        /// <summary>
        /// Constructs an instance of Water.
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
        }
        /// <summary>
        /// Sets the lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
