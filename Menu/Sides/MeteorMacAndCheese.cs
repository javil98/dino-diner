/*/*MeteorMacAndCheese.cs
 * Author: Jose C. Avila
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represent a MeteorMacAndCheese that inherits from the Side class.
    /// </summary>
    public class MeteorMacAndCheese : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// A Size variable that stores the size of the side.
        /// </summary>
        /// 
        protected Size size;

      
        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }


        /// <summary>
        /// A property that sets the size of the side and the price and calories based on the size of the instance. It gets the Size of the side.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;

                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }
        /// <summary>
        /// Constructs an instance of a MeteorMacAndCheese.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
            
        }

        public override string ToString()
        {
            return (Size + " Meteor Mac and Cheese");
        }
    }
}
