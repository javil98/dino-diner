using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
    

        public double Price { get; set; }
        public uint Calories { get; set; }
        
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                return ingredients;
            }
                
        }

        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            Ingredients.Add("Chicken Nuggets");
        }
    }
}
