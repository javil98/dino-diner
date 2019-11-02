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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst Brontowurst { get; set; }

        private bool IsCombo { get; set; } = false;

        private CretaceousCombo Combo {get; set;}

        /// <summary>
        /// Creates a new page of CustomizeBrontoWurst
        /// </summary>
        /// <param name="bw">A Brontowurst that is added to the parameter.</param>
        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.Brontowurst = bw;
        }

        /// <summary>
        /// Creates a new page of CutomizeBrontoWurst.
        /// </summary>
        /// <param name="combo">The combo choosen by the user.</param>
        /// <param name="IsCombo">A boolean that indicates if the page was created by the Combo customization.</param>
        public CustomizeBrontowurst(CretaceousCombo combo, bool IsCombo)
        {
            InitializeComponent();
            this.Combo = combo;
            this.IsCombo = IsCombo;
            this.Brontowurst = (Brontowurst)combo.Entree;
        }

        /// <summary>
        /// Holds the bun when the hold bun button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            Brontowurst.HoldBun();
        }

        /// <summary>
        /// Holds the Onion when the hold Onion button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            Brontowurst.HoldOnion();
        }

        /// <summary>
        /// Holds the Peppers when the hold Peppers button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            Brontowurst.HoldPeppers();
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

        /// <summary>
        /// Create a new page of CustomizeBrontwurst.
        /// </summary>
        public CustomizeBrontowurst()
        {
            InitializeComponent();
        }


    }
}
