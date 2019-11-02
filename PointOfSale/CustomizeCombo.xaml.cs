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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
       private CretaceousCombo combo { get; set; }

        /// <summary>
        /// Creates a new page of CustomizeCombo.
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new page of CustomizeCombo and stores the parameter in to the field property.
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }


        /// <summary>
        /// When the user clicks the Side button, it will take the user to the side selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo.Side));
        }

        /// <summary>
        /// When the user clicks the drink button, it will take the user to the Drink Selection page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo.Drink));
        }

        /// <summary>
        /// Makes the order a small when button "Small" is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSmall(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        }

        /// <summary>
        /// Makes the order a Medium when button "Medium" is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectMedium(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        }

        /// <summary>
        /// Makes the order a Large when button "Large" is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectLarge(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
