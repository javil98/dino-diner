/*DinoNuggets.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class representing the DinoNuggets entree.
    /// </summary>
    public class DinoNuggets:Entrees
    {
        /// <summary>
        /// Keeps track of the number of nuggets for a DinoNugget object.
        /// </summary>
        public int NuggetCount = 6;
    
        /// <summary>
        /// Constructs an instance of DinoNuggets.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
        }
        /// <summary>
        /// Gets the list of ingredients of a DinoNuggets object.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> ();
                for(int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
                
        }
        /// <summary>
        /// Modiefies the price, calories and the count of a DinoNugget object.
        /// </summary>
        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            NuggetCount++;
        }
    }
}
