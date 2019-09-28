/*VelociWrap.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Describes a class that represents a VelociWrap.
    /// </summary>
    public class VelociWrap : Entree
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        /// <summary>
        /// Constructs an instance of VelociWrap.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Gets a list of ingredients for an instance of VelociWrap.
        /// </summary>
        public override List<string> Ingredients
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
        /// <summary>
        /// Sets the value of dressing to false of a Steakosaurus burger.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// Sets the value of lettuce to false of a Steakosaurus burger.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Sets the value of cheese to false of a Steakosaurus burger.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
