using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken Breast" };
                ingredients.Add("Flour Tortilla");
                if (dressing) ingredients.Add("Romaine Lettuce");
                if (lettuce) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
