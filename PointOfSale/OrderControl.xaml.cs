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
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Sets and gets a NavigatonService
        /// </summary>
        public NavigationService NavigationService { get; set; }

        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes the user to the side selection if they click a side in the order control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            else if(OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            else if(OrderItems.SelectedItem is Entree entree)
            {
                if(entree is DinoNuggets nuggets)
                {
                    NavigationService?.Navigate(new CustomizeDinoNuggets(nuggets));
                }
                
                else if (entree is PrehistoricPBJ sandwhich)
                {
                    NavigationService?.Navigate(new CustomizePrehistoricPBJ(sandwhich));
                }

                else if (entree is Brontowurst bw)
                {
                    NavigationService?.Navigate(new CustomizeBrontowurst(bw));
                }

                else if (entree is SteakosaurusBurger burger)
                {
                    NavigationService?.Navigate(new CustomizeSteakosaurusBurger(burger));
                }

                else if (entree is TRexKingBurger burger1)
                {
                    NavigationService?.Navigate(new CustomizeTRexKingBurger(burger1));
                }

                else if (entree is VelociWrap wrap)
                {
                    NavigationService?.Navigate(new CustomizeVelociWrap(wrap));
                }
            }
        }

       

        /// <summary>
        /// Removes an item if its a element, and in the element if its an item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                    if (element.DataContext is IOrderItem item)
                        order.Remove(item);
            }
        }

       

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
