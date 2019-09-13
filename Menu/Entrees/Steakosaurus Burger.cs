﻿using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool mustard = true;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621; 

        }
        
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

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

    }
}
