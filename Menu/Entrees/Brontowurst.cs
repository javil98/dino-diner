using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public double Price { get; set; }
        public uint Calories { get; set; }


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
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onions) ingreadients.Add("Onion");
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
            this.bun = false;
        }


    }
}
