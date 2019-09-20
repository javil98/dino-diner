using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// 
    /// </summary>
    public class Brontowurst:Entrees
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;


        /// <summary>
        /// 
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;

            }
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }


    }
}
