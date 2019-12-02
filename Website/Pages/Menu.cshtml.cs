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
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        [BindProperty]
        public double? minPrice { get; set; }
        
        [BindProperty]
        public double? maxPrice { get; set; }


        public Menu menuL = new Menu();

        public List<IMenuItem> menuResults;

   

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
            if(search.Length != 0)
            {
                menuResults = menuL.SearchName(menuResults, search);
            }
            if(menuCategory.Count != 0)
            {
                menuResults = menuL.SearchCategory(menuResults, menuCategory);
            }

            if(ingredients.Count != 0)
            {
                menuResults = menuL.SearchIngredients(menuResults, ingredients);
            }

            if(minPrice != null)
            {
                menuResults = menuL.SearchMinPrice(menuResults, (double)minPrice);
            }

            if(maxPrice != null)
            {
                menuResults = menuL.SearchMaxPrice(menuResults, (double)maxPrice);
            }
        }
    }
}