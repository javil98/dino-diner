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
        TRexKingBurger burger { get; set; }

        public CustomizeTRexKingBurger()
        {
            InitializeComponent();
        }

        public CustomizeTRexKingBurger(TRexKingBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }


        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            burger.HoldOnion();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            burger.HoldMayo();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            burger.HoldTomato();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            burger.HoldLettuce();
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
    }
}
