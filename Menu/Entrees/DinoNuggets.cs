/*DinoNuggets.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing the DinoNuggets entree.
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Keeps track of the number of nuggets for a DinoNugget object.
        /// </summary>
        public int NuggetCount = 6;

        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Returns the specials for the DinoNuggets.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (NuggetCount > 6) special.Add($"{NuggetCount- 6} Extra Nugget(s)");
                return special.ToArray();
                

            }
        }

        /// <summary>
        /// Constructs an instance of DinoNuggets.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
            NotifyOfPropertyChange("Calories");
            NotifyOfPropertyChange("Price");
            PriceBySize = (Price, Price, Price);
        }
        /// <summary>
        /// Gets the list of ingredients of a DinoNuggets object.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                NotifyOfPropertyChange("Special");
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Items");
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString() 
        {
            return "Dino-Nuggets";
        }
    }
}
