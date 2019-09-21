/*TRexKingBurger.cs
 * Author: Jose C. Avila
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Describes a class that represents a TRexKingBurger.
    /// </summary>
    public class TRexKingBurger: Entrees
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
        /// Contructs an instance of TRexKingBurger.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// Gets a list of ingredients of an instance of TRexKingBurger.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie"  };
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
        }
        /// <summary>
        /// Sets the value of lettuce to false of a Steakosaurus burger.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Sets the value of tomatoe to false of a Steakosaurus burger.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// Sets the value of pickle to false of a Steakosaurus burger.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Sets the value of ketchup to false of a Steakosaurus burger.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Sets the value of mustard to false of a Steakosaurus burger.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// Sets the value of onion to false of a Steakosaurus burger.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Sets the value of Mayo to false of a Steakosaurus burger.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
