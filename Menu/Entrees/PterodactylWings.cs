using System;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        private double Price { get; set; }
        private uint Calories { get; set; }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken" };
                ingredients.Add("Wing Sauce");
                return Ingredients;
            }
        }
    }
}
