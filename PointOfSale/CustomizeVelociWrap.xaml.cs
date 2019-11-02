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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        private VelociWrap Wrap { get; set; }

        private bool IsCombo { get; set; } = false;

        private CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Constructor that creates a new page.
        /// </summary>
        public CustomizeVelociWrap()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor that creates a new page and stores the combo in the field property.
        /// </summary>
        /// <param name="wrap">A velociwrap.</param>
        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.Wrap = wrap;
        }
        /// <summary>
        /// Constructor that creates a new page and stores the parameters into the field properties.
        /// </summary>
        /// <param name="combo">The combo chosen</param>
        /// <param name="IsCombo">A boolean that indicates if this page was initialized from the combo page.</param>
        public CustomizeVelociWrap(CretaceousCombo combo, bool IsCombo)
        {
            InitializeComponent();
            this.Combo = combo;
            this.IsCombo = IsCombo;
            this.Wrap = (VelociWrap) combo.Entree;
        }

        /// <summary>
        /// Holds the cheese on the wrap.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            Wrap.HoldCheese();
        }

        /// <summary>
        /// Holds the dressing of the wrap.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            Wrap.HoldDressing();
        }

        /// <summary>
        /// Holds the lettuce on the wrap.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            Wrap.HoldLettuce();
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
