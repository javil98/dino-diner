/*
 * JurassicJava.cs
 * Author: Jose C. Avila
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a JurrasicJava which inherits from the Drink base class.
    /// </summary>
    public class JurassicJava : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets Decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Gets and sets RoomForCream
        /// </summary>
        public bool RoomForCream { get; set; } = false;


        /// <summary>
        /// Gets and sets the description 
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets and sets the specials
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice) special.Add("Add Ice");
                return special.ToArray();

            }
        }

        private Size size;
        /// <summary>
        /// Gets and sets the Size
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Size");
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Size");
                        break;

                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Size");
                        break;
                }
                

            }

        }

        /// <summary>
        /// Gets and sets the Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Coffee" };
            }
        }

        //
        /// <summary>
        /// Constructs an instance of JurssicJava
        /// </summary>
        public JurassicJava()
        {
            Price = 0.59;
            Calories = 2;
            Ice = false;
        }

        /// <summary>
        /// Returns a string that contains the name of a the item.
        /// </summary>
        /// <returns> A string that contains the name of an item.</returns>
        public override string ToString()
        {
            if (Decaf) return (Size + " Decaf Jurassic Java");
            else return (Size + " Jurassic Java");
  
        }

        /// <summary>
        /// Sets RoomForCream to true;
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }


    }
}
