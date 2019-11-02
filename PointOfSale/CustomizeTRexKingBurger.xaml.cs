using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger Burger { get; set; }

        private CretaceousCombo Combo { get; set; }

        private bool IsCombo { get; set; } = false;

        /// <summary>
        /// Creates a new CustomizeTRexBurger pages.
        /// </summary>
        public CustomizeTRexKingBurger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new page of CustomizeTRexBurger page, and stores the burger into the field.
        /// </summary>
        /// <param name="burger">A TRexBurger.</param>
        public CustomizeTRexKingBurger(TRexKingBurger burger)
        {
            InitializeComponent();
            this.Burger = burger;
        }

        /// <summary>
        /// Creates a new page of Customize TRexBurger page and stores the paremeters into the field properties.
        /// </summary>
        /// <param name="combo">The combo that was chosen.</param>
        /// <param name="IsCombo">A boolean that represents if this page was created from the Combo customize page.</param>
        public CustomizeTRexKingBurger(CretaceousCombo combo, bool IsCombo)
        {
            InitializeComponent();
            this.Combo = combo;
            this.IsCombo = IsCombo;
            this.Burger = (TRexKingBurger)combo.Entree;
        }

        /// <summary>
        /// Holds the bun when the hold bun button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            Burger.HoldBun();
        }

        /// <summary>
        /// Holds the ketchup when the hold ketchup button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            Burger.HoldKetchup();
        }

        /// <summary>
        /// Holds the Mustard when the hold Mustard button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            Burger.HoldMustard();
        }

        /// <summary>
        /// Holds the Pickle when the hold Pickle button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            Burger.HoldPickle();
        }

        /// <summary>
        /// Holds the onion when the hold onion button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            Burger.HoldOnion();
        }

        /// <summary>
        /// Holds the mayo when the hold mayo button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            Burger.HoldMayo();
        }

        /// <summary>
        /// Holds the Tomato when the hold Tomato button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            Burger.HoldTomato();
        }

        /// <summary>
        /// Holds the Lettuce when the hold Lettuce button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            Burger.HoldLettuce();
        }

        /// <summary>
        /// Will navigate to the Customize page if IsCombo is true. If false, it will go to Menu Catergory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (IsCombo)
            {
                NavigationService.Navigate(new CustomizeCombo(Combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
