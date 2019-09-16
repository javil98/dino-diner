using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class representing a PrehistoricPBJ
    /// </summary>
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;
        /// <summary>
        /// Get and sets the price of the PrehistoricPBJ.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets and sets the Calories of the PrehistoricPBJ.
        /// </summary>
        public uint Calories { get; set; }
        
        /// <summary>
        /// Gets a list of ingredients for a PrehistoricPBJ.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs an object of PrehistoricPBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Sets the value of peanutButter to false.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// Sets the value of jelly to false.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
