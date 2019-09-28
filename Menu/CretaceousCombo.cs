using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        private Size size = Size.Small;

        public Size Size
        {
            get { return size; }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
            }
        }
        /// <summary>
        /// No state is present since there is not private backing field.
        /// </summary>
        public double Price
        {
            get
            {
                return (this.Entree.Price + this.Side.Price + this.Drink.Price - 0.25);
            }
        }

        public uint Calories
        {
            get
            {
                return this.Entree.Calories + this.Drink.Calories + this.Side.Calories;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(this.Drink.Ingredients);
                ingredients.AddRange(this.Side.Ingredients);
                ingredients.AddRange(this.Entree.Ingredients);
                return ingredients;
            }
        }
        private CretaceousCombo() { }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
    }
}
