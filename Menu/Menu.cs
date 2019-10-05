/*
 * Menu.cs
 * 
 * Author: Jose C. Avila
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a Menu for the Dino Diner.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Gets a list of available menu items.
        /// </summary>
        public List<Object> AvailableMenuItems
        {
            get
            {
                List<Object> MenuItemsList = new List<Object>();
                MenuItemsList.AddRange(AvailableEntrees);
                MenuItemsList.AddRange(AvailableDrinks);
                MenuItemsList.AddRange(AvailableSides);
                MenuItemsList.AddRange(AvailableCombos);

                return MenuItemsList;
            }
        }

        /// <summary>
        /// Gets a list of available entrees.
        /// </summary>
        public List<Entree> AvailableEntrees 
        {
            get
            {
                List<Entree> EntreeList = new List<Entree> { new Brontowurst(), new DinoNuggets(), new PrehistoricPBJ(), new PterodactylWings(), new SteakosaurusBurger(), new TRexKingBurger(), new VelociWrap() };
                return EntreeList;
            }

        }

        /// <summary>
        /// Gets a list of available Drinks.
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> AvailableDrinks = new List<Drink> { new JurassicJava(), new Sodasaurus(), new TyrannoTea(), new Water() };
                return AvailableDrinks;
            }

        }
        /// <summary>
        /// Gets a list of available siides.
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> AvailableSides = new List<Side> { new Fryceritops(), new MeteorMacAndCheese(), new MezzorellaSticks(), new Triceritots() };
                return AvailableSides;
            }
        }

        /// <summary>
        /// Gets a list of available combos.
        /// </summary>
        public List<Side> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> AvailableCombos = new List<CretaceousCombo> { new CretaceousCombo(new Brontowurst()), new CretaceousCombo(new DinoNuggets()), new CretaceousCombo(new PrehistoricPBJ()), new CretaceousCombo(new PterodactylWings()), new CretaceousCombo(new SteakosaurusBurger()), new CretaceousCombo(new TRexKingBurger()), new CretaceousCombo(new VelociWrap()) };
                return AvailableSides;
            }
        }

        /// <summary>
        /// Returns a string that contains all of the menus available in the menu.
        /// </summary>
        /// <returns> A string that contains all of the menu items.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Object x in AvailableMenuItems)
            {
                sb.Append(x.ToString() + "\n");
            }
            return sb.ToString();
        }
    }

    
}
