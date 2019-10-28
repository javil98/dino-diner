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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Gets and sets a drink.
        /// </summary>
        public Drink Drink { get; set; }

        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sends the user to the page when the flavor button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection()) ;
        }

        /// <summary>
        /// Constructs a new Initialize componenet and sets the drink to the parameter of the contstructer.
        /// </summary>
        /// <param name="drink">The drink that is selected.</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }

        /// <summary>
        /// If the datacontext is of order, it will add the drink to the order and the drink property 
        /// will be set to the parameter drink.
        /// </summary>
        /// <param name="drink"></param>
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(drink);
                this.Drink = drink;
            }
        }

        /// <summary>
        /// Adds a Sodasaurus to the ordercontrol and order. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSodasaurus(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Sodasaurus());

        }

        /// <summary>
        /// Adds a TyrannoTea to the ordercontrol and order. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTyrannoTea(object sender, RoutedEventArgs args)
        {

            SelectDrink(new TyrannoTea());

        }

        /// <summary>
        /// Adds a JurassicJava to the ordercontrol and order. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddJurassicJava(object sender, RoutedEventArgs args)
        {
            SelectDrink(new JurassicJava());

        }

        /// <summary>
        /// Adds a Water to the ordercontrol and order. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddWater(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Water());

        }

        public void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
                this.Drink.Size = size;
        }

        /// <summary>
        /// Sets the size of the drink to small and takes the user back to the menuCategorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the size of the drink to medium and takes the user back to the menuCategorySelection page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the size of the drink to large and takes the user back to the menuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// When the "Done button is clicked, it will take the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
       public void ClickDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
