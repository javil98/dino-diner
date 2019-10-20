/*Triceritots.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a MezzorellaSticks that inherits from the Triceritots class that inherits from the Side class.
    /// </summary>
    public class Triceritots : Side, INotifyPropertyChanged 
    {
        /// <summary>
        /// A variable that represents the size of the side.
        /// </summary>
        protected Size size;

        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets and sets the special
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
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
                        this.Calories = 590;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
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

        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Constructs an instance of a Triceritots.
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            return (Size + " Triceritots");
        }
    }
}
