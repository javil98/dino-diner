/*Brontowurst.cs
 * Author: Jose C. Avila
 */

using System.Collections.Generic;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a Brontowurst.
    /// </summary>
    public class Brontowurst : Entree, INotifyPropertyChanged
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onions) special.Add("Hold Onion");
                return special.ToArray();

            }
        }

        /// <summary>
        /// A constructor that creates an instance of a Brontowurst.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Gets a list of ingredients for a Brontowurst.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;

            }
        }


        /// <summary>
        /// Sets the value of bun  to false.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Sets the value of Peppers to false.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Sets the value of onion to false.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }


    }
}
