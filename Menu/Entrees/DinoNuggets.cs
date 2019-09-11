using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public bool SixChickenNuggets = true;

        private double Price { get; set; }
        private uint Calories { get; set; }
        
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if(SixChickentNuggets) List.Add()
            }
        }
    }
}
