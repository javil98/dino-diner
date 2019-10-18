/*
 * Water.cs
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    // A class that represents Water which inherits from the Drink base class.
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

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
        /// Gets and set the description.
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
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();

            }
        }
        /// <summary>
        /// Gets a list of ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Lemon == false) { return new List<string> { "Water" }; }
                else { return new List<string> { "Water", "Lemon" }; }
            }
             
        }

        /// <summary>
        /// Constructs an instance of Water.
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
        }
        /// <summary>
        /// Sets the lemon to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            return Size + " Water";
        }
    }
}
