/*Fryceritops.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a Fryceritops which inherits from the Side class.
    /// </summary>
    public class Fryceritops : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// A variable that stores the size of the Side.
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
        /// Gets and sets the special.
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
                        this.Calories = 480;

                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                }
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Size");

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
                return new List<string> { "Potato", "Salt", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// Constructs an instance of a Fryceritops.
        /// </summary>
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
        }

        public override string ToString()
        {
            return (Size + " Fryceritops");
        }

    }
}
