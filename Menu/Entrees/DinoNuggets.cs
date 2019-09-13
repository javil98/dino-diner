using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public int nuggetCount = 6;
    

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
                List<string> ingredients = new List<string> ();
                for(int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
                
        }

        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            nuggetCount++;
        }
    }
}
