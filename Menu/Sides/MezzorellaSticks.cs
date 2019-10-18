/*MezzorellaSticks.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a MezzorellaSticks that inherits from the Side class.
    /// </summary>
    public class MezzorellaSticks : Side, INotifyPropertyChanged
    {
        protected Size size;

        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and 
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                        this.Calories = 720;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;

                }
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
                return new List<string> { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Constructs an instance of a MezzorellaSticks
        /// /// </summary>
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
            
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            return (Size + " Mezzorella Sticks");
        }
    }
}
