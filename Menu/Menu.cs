﻿/*
 * Menu.cs
 * 
 * Author: Jose C. Avila
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> MenuItemsList = new List<IMenuItem>();
                MenuItemsList.AddRange(AvailableEntrees);
                MenuItemsList.AddRange(AvailableDrinks);
                MenuItemsList.AddRange(AvailableSides);
                MenuItemsList.AddRange(AvailableCombos);

                return MenuItemsList;
            }
        }

        public List<string> AvailableIngredients
        {
            get
            {
                return AllIngredients();
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
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> AvailableCombos = new List<CretaceousCombo> { new CretaceousCombo(new Brontowurst()), new CretaceousCombo(new DinoNuggets()), new CretaceousCombo(new PrehistoricPBJ()), new CretaceousCombo(new PterodactylWings()), new CretaceousCombo(new SteakosaurusBurger()), new CretaceousCombo(new TRexKingBurger()), new CretaceousCombo(new VelociWrap()) };
                return AvailableCombos;
            }
        }

        /// <summary>
        /// Returns a string that contains all of the items available in the menu.
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

        public List<string> AllIngredients()
        {
            HashSet<string> ingredientList = new HashSet<string>();

            foreach(Entree entree in AvailableEntrees)
            {
                foreach(string ingredient in entree.Ingredients)
                {
                    ingredientList.Add(ingredient);
                }
            }

            foreach (Drink drink in AvailableDrinks)
            {
                foreach (string ingredient in drink.Ingredients)
                {
                    ingredientList.Add(ingredient);
                }
            }

            foreach (Side side in AvailableSides)
            {
                foreach (string ingredient in side.Ingredients)
                {
                    ingredientList.Add(ingredient);
                }
            }

            return ingredientList.ToList();

        }
        public List<IMenuItem> SearchMinPrice(List<IMenuItem> items, double minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach(IMenuItem item in items)
            {
                if(item.Price > minPrice)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public List<IMenuItem> SearchMaxPrice(List<IMenuItem> items, double maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in items)
            {
                if (item.Price < maxPrice)
                {
                    results.Add(item);
                }
            }

            return results;
        }


        public List<IMenuItem> SearchIngredients(List<IMenuItem> items, List<string> category)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach(IMenuItem item in items)
            {
                foreach(string ingredient in item.Ingredients)
                {
                    if (category.Contains(ingredient))
                    {
                        results.Add(item);
                    }
                }
                
            }

            return results;
        }

        public List<IMenuItem> SearchCategory(List<IMenuItem> items, List<string> category)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach(IMenuItem item in items)
            {
                if(item is Entree && category.Contains("Entree"))
                {
                    results.Add(item);
                }

                if(item is CretaceousCombo && category.Contains("Combo"))
                {
                    results.Add(item);
                }

                if (item is Drink && category.Contains("Drink"))
                {
                    results.Add(item);
                }

                if (item is Side && category.Contains("Side"))
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }

    
}
