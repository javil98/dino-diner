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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        private SteakosaurusBurger Burger { get; set; }

        private bool IsCombo { get; set; } = false;
        
        private CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Creates a new page of CustomizeSteakosaurusBurger page
        /// </summary>
        public CustomizeSteakosaurusBurger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new page of CustomizeSteakosaurusBurger page, and stores the burger into the field.
        /// </summary>
        /// <param name="burger">A steakosaurusburger</param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger burger)
        {
            InitializeComponent();
            this.Burger = burger;
        }

        /// <summary>
        /// Creates a new page of CustomizeSteakosaurusBurger page, and stores the paremeters into the property fields.
        /// </summary>
        /// <param name="combo">The combo choosen by the user.</param>
        /// <param name="IsCombo"> A boolean that indicates whether this page was created becuase of coming from the Combo selction page</param>
        public CustomizeSteakosaurusBurger(CretaceousCombo combo, bool IsCombo)
        {
            InitializeComponent();
            this.Combo = combo;
            this.IsCombo = IsCombo;
            this.Burger = (SteakosaurusBurger)combo.Entree;
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
        /// Holds the Ketchup when the hold Ketchup button is clicked.
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
