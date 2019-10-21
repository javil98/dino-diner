/*Brontowurst.cs
 * Author: Nathan Bean
 * Modified by: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents Sides.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, Calories and 
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets the description of Drink.
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// Gets a list of the Specials.
        /// </summary>
        public virtual string[] Special { get; }

    }
}
