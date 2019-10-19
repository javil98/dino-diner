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
        /// 
        /// </summary>
        public virtual string[] Special { get; }

        public virtual string Description { get; }


    }
}
