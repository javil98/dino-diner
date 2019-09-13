using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

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
                return ingredients;
            }
        }
    }
}
