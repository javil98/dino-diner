/*Steakosaurus.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a SteakosaurusBurger.
    /// </summary>
    public class SteakosaurusBurger : Entree, INotifyPropertyChanged
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool mustard = true;


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
                if (!ketchup) special.Add("Hold Ketchup");
                if (!pickle) special.Add("Hold Pickle");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();

            }
        }
        /// <summary>
        /// Constructs an instance of SteakosaurusBurger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;

        }
        /// <summary>
        /// Ges a list of ingredients for a Steakosaurus object.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (ketchup) ingredients.Add("Ketchup");
                if (pickle) ingredients.Add("Pickle");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the value of bun to false of a Steakosaurus burger.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Sets the value of pickle to false of a Steakosaurus burger.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Sets the value of mustard to false of a Steakosaurus burger.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Sets the value of ketchup to false of a Steakosaurus burger.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

    }
}
