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
        private Brontowurst brontowurst { get; set; }

        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.brontowurst = bw;
        }
        

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldBun();
        }

        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldOnion();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldPeppers();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        public CustomizeBrontowurst()
        {
            InitializeComponent();
        }


    }
}
