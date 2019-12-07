using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// A property that stores what the user wants to search for. 
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// A property that stores the categories that the user wants to search for. 
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// A property that stores the ingredients that the user wants to search for. 
        /// </summary>
        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        /// <summary>
        /// A property that stores the min price that the user wants to search for. 
        /// </summary>
        [BindProperty]
        public double? minPrice { get; set; }
        
        /// <summary>
        /// A property that stores the max price that the user wants to search for.  
        /// </summary>
        [BindProperty]
        public double? maxPrice { get; set; }

        /// <summary>
        /// A menu that allows us to acces the methods from the menu class.
        /// </summary>
        public Menu menuL = new Menu();

        /// <summary>
        /// A list that stores the results of the searches.
        /// </summary>
        public IEnumerable<IMenuItem> menuResults;

        public IEnumerable<IMenuItem> CombosResults
        {
            get
            {
                return menuResults.OfType<CretaceousCombo>();
            }
        }

        public IEnumerable<IMenuItem> EntreeResults
        {
            get
            {
                return menuResults.OfType<Entree>();
            }
        }

        public IEnumerable<IMenuItem> DrinkResults
        {
            get
            {
                return menuResults.OfType<Drink>();
            }
        }

        public IEnumerable<IMenuItem> SideResults
        {
            get
            {
                return menuResults.OfType<Side>();
            }
        }


        /// <summary>
        /// A property that returns the availble ingredients of the menu.
        /// </summary>
        public List<string> AvailableIngredients
        { 
     
            get
            {
                return menuL.AvailableIngredients;
            }
            
        } 

        public void OnGet()
        {
            menuResults = menuL.AvailableMenuItems;
        }

        public void OnPost()
        {
            menuResults = menuL.AvailableMenuItems;
            if(search != null)
            {
                menuResults = menuResults.Where(item => item.ToString().Contains(search));
                //menuResults = menuL.SearchName(menuResults, search);
            }

            if(minPrice != null)
            {
                menuResults = menuResults.Where(item => item.PriceBySize.Item1 >= minPrice);
                //menuResults = menuL.SearchMinPrice(menuResults, (double)minPrice);
            }

            if(maxPrice != null)
            {
                menuResults = menuResults.Where(item => item.PriceBySize.Item3 <= maxPrice);
            }

            if (ingredients.Count != 0)
            {
                menuResults = menuResults.Where(item =>
                {
                    foreach (string thing in ingredients)
                    {
                        
                            if (item.Ingredients.Contains(thing))
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                    }
                    return false;
       
                });
                //menuResults = menuL.SearchIngredients(menuResults, ingredients);
            }

            if (menuCategory.Count != 0)
            {
                menuResults = menuL.SearchCategory(menuResults, menuCategory);
            }

            



        }
    }
}