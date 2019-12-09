/*TRexKingBurger.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Describes a class that represents a TRexKingBurger.
    /// </summary>
    public class TRexKingBurger : Entree, INotifyPropertyChanged
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets and sets the special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();

            }
        }
        /// <summary>
        /// Contructs an instance of TRexKingBurger.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
            PriceBySize = (8.45, 8.45, 8.45);
        }
        /// <summary>
        /// Gets a list of ingredients of an instance of TRexKingBurger.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");

                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                if (ketchup) ingredients.Add("Ketchup");
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
        /// Sets the value of lettuce to false of a Steakosaurus burger.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Sets the value of tomatoe to false of a Steakosaurus burger.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
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
        /// Sets the value of ketchup to false of a Steakosaurus burger.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
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
        /// Sets the value of onion to false of a Steakosaurus burger.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of Mayo to false of a Steakosaurus burger.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
