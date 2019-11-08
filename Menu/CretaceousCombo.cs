/*
 * CretaceousCombo.cs
 * 
 * Author: Jose C. Avila
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a CretaceousCombo that uses the IMenuItem interface.
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {

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
        /// Get and sets the  entree that the combo has.
        /// </summary>
        public Entree Entree { get; set; }

        private Drink drink;
        /// <summary>
        /// Gets and sets the drink that the combo has.
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }

            set
            {
                drink = value;
                drink.PropertyChanged += OnItemChange;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Drink");
            }
        }

        private Side side;
        /// <summary>
        /// Gets and set the Side that the combo has.
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                side.PropertyChanged += OnItemChange;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Side");

            }
        }

        /// <summary>
        /// Private variable that stores the size of the combo.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of the combo.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Gets the Price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return (this.Entree.Price + this.Side.Price + this.Drink.Price - 0.25);
            }
        }

        /// <summary>
        /// Gets the Calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return this.Entree.Calories + this.Drink.Calories + this.Side.Calories;
            }
        }

        /// <summary>
        /// Gets the list of Ingredients that the combo contains.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(this.Drink.Ingredients);
                ingredients.AddRange(this.Side.Ingredients);
                ingredients.AddRange(this.Entree.Ingredients);
                string[] ingredient = ingredients.ToArray();
                List<string> ingredients2 = new List<string>(ingredient);
                return ingredients2;
            }
        }
        /// <summary>
        /// Default constructor for the combo.
        /// </summary>
        public CretaceousCombo() { }

        /// <summary>
        /// Combo for the Cretaceous combo that creates a new instance of a Cretaceous Combo.
        /// </summary>
        /// <param name="entree">The entree that combo will have.</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            entree.PropertyChanged += OnItemChange;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Returns a string that contains the name of the combo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return (Entree + " Combo");

        }

        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);

                return ingredients.ToArray();

            }
        }

        private void OnItemChange(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
        }
    }
}
