/*Entree.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a Entree class that is used as a base class for the sides.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// A property that represents the Price of an entree.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// A property that represents the calories of an entree.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// A property gets and sets the ingredients of an entree.
        /// </summary>
        public virtual List<string> Ingredients { get; set; }

        /// <summary>
        /// Gets and returns a tuple that stores the price for the entrees by the size.
        /// </summary>
        public (double, double, double) PriceBySize { get; set; }

        /// <summary>
        /// Gets and sets a tuple that stores the calories of a entrees by the size.
        /// </summary>
        public (uint, uint, uint) CaloriesBySize { get; set; }


        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and 
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// returns the specials for the entree.
        /// </summary>
        public virtual string[] Special { get; }

        /// <summary>
        /// Returns the description of the entree.
        /// </summary>
        public virtual string Description { get; }


    }
}
