/*
 * IMenuItem.cs
 * 
 * Author: Jose C. Avila
 * 
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An interface that is used for the sides, entrees, and drinks.
    /// </summary>
     public interface IMenuItem
    {
        /// <summary>
        /// Gets and sets the Price of the Item.
        /// </summary>
         double Price { get; }

        /// <summary>
        /// Gets and sets the calories of the item.
        /// </summary>
         uint Calories { get; }

        /// <summary>
        /// Gets and sets the ingredients of the item.
        /// </summary>
        List<string> Ingredients { get; }


    }
}
