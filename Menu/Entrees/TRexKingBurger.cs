﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    
    public class TRexKingBurger
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Three Steakburger Patties" };
                if (bun) ingredients.Add("Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}