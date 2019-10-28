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
    /// Interaction logic for Flavor.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        Sodasaurus Soda { get; set; }
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// An overload constructor that sets the Soda property to the soda parameter.
        /// </summary>
        /// <param name="soda"></param>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            Soda = soda;
        }

        /// <summary>
        /// Sets the flavor of the soda to the flavor parameter.
        /// </summary>
        /// <param name="flavor"></param>
        public void SelectFlavor(DinoDiner.Menu.SodasaurusFlavor flavor)
        {
            if (Soda != null)
                this.Soda.Flavor = flavor;
        }

        /// <summary>
        /// Sets the flavor of the sodasaurus to Cola.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeCola(object sender, RoutedEventArgs args)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Cola);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the flavor of the sodasaurus to Cherry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeCherry(object sender, RoutedEventArgs args)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Cherry);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the flavor of the sodasaurus to Vanilla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeVanilla(object sender, RoutedEventArgs args)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Vanilla);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the flavor of the sodasaurus to Chocolate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnMakeChocolate(object sender, RoutedEventArgs args)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Chocolate);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the flavor of the sodasaurus to Lime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnMakeLime(object sender, RoutedEventArgs args)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Lime);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the flavor of the sodasaurus to Orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnMakeOrange(object sender, RoutedEventArgs args)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Orange);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the flavor of the sodasaurus to RootBeer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnMakeRootBeer(object sender, RoutedEventArgs args)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.RootBeer);
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
