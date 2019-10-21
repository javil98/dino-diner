/*
 * Drink.cs
 * Author: Nathan Bean
 * Modified by: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    /// <summary>
    /// A class that represents a Drink, which is a used as a base class for the rest of the drinks in the project.
    /// </summary>
    public abstract class Drink :IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Gets and sets the Size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets and sets Ice
        /// </summary>
        public bool Ice { get; protected set; } = true;

        /// <summary>
        /// Gets and sets Price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the Calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets and set the Ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; set; }

        /// <summary>
        /// Sets the boolean value of Ice to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

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
