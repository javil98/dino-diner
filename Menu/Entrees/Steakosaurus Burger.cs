using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool mustard = true;

        /// <summary>
        /// Gets and sets the price of a SteakosaurusBurger.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets and sets the calories of a SteakosaurusBurger.
        /// </summary>
        public uint Calories { get; set; }
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
        public List<string> Ingredients
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
        }
        /// <summary>
        /// Sets the value of pickle to false of a Steakosaurus burger.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Sets the value of mustard to false of a Steakosaurus burger.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// Sets the value of ketchup to false of a Steakosaurus burger.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

    }
}
