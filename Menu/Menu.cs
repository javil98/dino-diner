using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    
    public class Menu
    {
        /// <summary>
        /// Make the list of type object
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

        public List<Entree> AvailableEntrees 
        {
            get
            {
                List<Entree> EntreeList = new List<Entree> { new Brontowurst(), new DinoNuggets(), new PrehistoricPBJ(), new PterodactylWings(), new SteakosaurusBurger(), new TRexKingBurger(), new VelociWrap() };
                return EntreeList;
            }

        }

        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> AvailableDrinks = new List<Drink> { new JurassicJava(), new Sodasaurus(), new TyrannoTea(), new Water() };
                return AvailableDrinks;
            }

        }

        public List<Side> AvailableSides
        {
            get
            {
                List<Side> AvailableSides = new List<Side> { new Fryceritops(), new MeteorMacAndCheese(), new MezzorellaSticks(), new Triceritots() };
                return AvailableSides;
            }
        }

        public List<Side> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> AvailableCombos = new List<CretaceousCombo> { new CretaceousCombo(new Brontowurst()), new CretaceousCombo(new DinoNuggets()), new CretaceousCombo(new PrehistoricPBJ()), new CretaceousCombo(new PterodactylWings()), new CretaceousCombo(new SteakosaurusBurger()), new CretaceousCombo(new TRexKingBurger()), new CretaceousCombo(new VelociWrap()) };
                return AvailableSides;
            }
        }

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
