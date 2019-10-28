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
            if (OrderItems.SelectedItem is Side)
            {
                NavigationService?.Navigate(new SideSelection());
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
                    order.Items.Remove(item);
            }
        }

       

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
