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

        private CretaceousCombo Combo { get; set; }

        private bool IsCombo { get; set; } = false;

        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(CretaceousCombo combo, bool IsCombo)
        {
            InitializeComponent();
            this.IsCombo = IsCombo;
            this.Combo = combo;
            this.Drink = combo.Drink;
            ButtonSetup();
        }

        

        /// <summary>
        /// Constructs a new Initialize componenet and sets the drink to the parameter of the contstructer.
        /// </summary>
        /// <param name="drink">The drink that is selected.</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
            ButtonSetup();
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
                if (!IsCombo)
                {
                    order.Add(drink);
                    this.Drink = drink;
                }
                else
                {
                    Combo.Drink = drink;
                    this.Drink = drink;
                }
            }
            ButtonSetup();
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
            
        }

        /// <summary>
        /// Sets the size of the drink to medium and takes the user back to the menuCategorySelection page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
            
        }

        /// <summary>
        /// Sets the size of the drink to large and takes the user back to the menuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
            
        }

        /// <summary>
        /// When the "Done button is clicked, it will take the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
       public void ClickDone(object sender, RoutedEventArgs args)
        {
            if (IsCombo)
            {
                NavigationService.GoBack();
            }

            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// When the flavor button is clicked, it takes the user to the FlavorSelection page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection(Drink));
        }

        /// <summary>
        /// When the HoldIce button is clicked, it holds the ice from the drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectHoldIce(object sender, RoutedEventArgs args)
        {
            this.Drink.HoldIce();
        }

        /// <summary>
        /// When the Lemon button is clicked, it adds lemon to the drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectLemon(object sender, RoutedEventArgs args)
        {
            if(Drink is TyrannoTea tea)
            {
                tea.AddLemon();
            }

            if(Drink is Water water)
            {
                water.AddLemon();
            }
        }

        /// <summary>
        /// When the sweet button is clicked, it will add sweet to Tyrannotea.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectSweet(object sender, RoutedEventArgs args)
        {
            if(Drink is TyrannoTea tea)
            {
                tea.Sweet = true;
            }
        }

        /// <summary>
        /// When the cream button is clicked, it will leave cream for Jurrassic Java.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectCream(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava coffee)
            {
                coffee.LeaveRoomForCream();
            }
        }

        /// <summary>
        /// When the decaf is click, it will make the jurrassic java to decaf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava coffee)
            {
                coffee.Decaf = true;
            }
        }

        /// <summary>
        /// When the Select Ice is added, it will add ice to the java.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectAddIce(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava coffee)
            {
                coffee.AddIce();
            }
        }

        private void ButtonSetup()
        {
            if (Drink != null)
            {
                BtnAddSodasaurus.IsEnabled = false;
                BtnAddTyrannoTea.IsEnabled = false;
                BtnAddWater.IsEnabled = false;
                BtnJurassicJava.IsEnabled = false;
                BtnAddSmall.IsEnabled = true;
                BtnAddMedium.IsEnabled = true;
                BtnAddLarge.IsEnabled = true;

            }
            if (Drink is Sodasaurus)
            {
                BtnAddSodasaurus.IsEnabled = true;
                BtnAddTyrannoTea.IsEnabled = false;
                BtnAddWater.IsEnabled = false;
                BtnJurassicJava.IsEnabled = false;
                BtnAddSmall.IsEnabled = true;
                BtnAddMedium.IsEnabled = true;
                BtnAddLarge.IsEnabled = true;

                Button flavor = new Button { Height = 60, Width = 165, Content = "Flavor" };
                Grid.SetRow(flavor, 1);
                Grid.SetColumn(flavor, 2);
                DrinkGrid.Children.Add(flavor);
                flavor.Click += new RoutedEventHandler(SelectFlavor);

                Button ice = new Button { Height = 60, Width = 165, Content = "Hold Ice" };
                Grid.SetRow(ice, 2);
                Grid.SetColumn(ice, 2);
                DrinkGrid.Children.Add(ice);
                ice.Click += new RoutedEventHandler(SelectHoldIce);
            }
            if(Drink is TyrannoTea)
            {
                BtnAddSodasaurus.IsEnabled = false;
                BtnAddTyrannoTea.IsEnabled = true;
                BtnAddWater.IsEnabled = false;
                BtnJurassicJava.IsEnabled = false;
                BtnAddSmall.IsEnabled = true;
                BtnAddMedium.IsEnabled = true;
                BtnAddLarge.IsEnabled = true;

                Button lemon = new Button { Height = 60, Width = 165, Content = "Add Lemon" };
                Grid.SetRow(lemon, 1);
                Grid.SetColumn(lemon, 2);
                DrinkGrid.Children.Add(lemon);
                lemon.Click += new RoutedEventHandler(SelectLemon);

                Button sweet = new Button { Height = 45, Width = 165, Content = "Make Sweet" };
                Grid.SetRow(sweet, 2);
                Grid.SetColumn(sweet, 2);
                DrinkGrid.Children.Add(sweet);
                sweet.Click += new RoutedEventHandler(SelectSweet);

                Button ice = new Button { Height = 60, Width = 165, Content = "Hold Ice" };
                Grid.SetRow(ice, 3);
                Grid.SetColumn(ice, 2);
                DrinkGrid.Children.Add(ice);
                ice.Click += new RoutedEventHandler(SelectHoldIce);

            }
            if(Drink is JurassicJava)
            {
                BtnAddSodasaurus.IsEnabled = false;
                BtnAddTyrannoTea.IsEnabled = false;
                BtnAddWater.IsEnabled = false;
                BtnJurassicJava.IsEnabled = true;
                BtnAddSmall.IsEnabled = true;
                BtnAddMedium.IsEnabled = true;
                BtnAddLarge.IsEnabled = true;

                Button cream = new Button { Height = 60, Width = 165, Content = "Room For Cream" };
                Grid.SetRow(cream, 1);
                Grid.SetColumn(cream, 2);
                DrinkGrid.Children.Add(cream);
                cream.Click += new RoutedEventHandler(SelectCream);

                Button decaf = new Button { Height = 45, Width = 165, Content = "Make Decaf" };
                Grid.SetRow(decaf, 2);
                Grid.SetColumn(decaf, 2);
                DrinkGrid.Children.Add(decaf);
                decaf.Click += new RoutedEventHandler(SelectDecaf);

                Button ice = new Button { Height = 60, Width = 165, Content = "Add Ice" };
                Grid.SetRow(ice, 3);
                Grid.SetColumn(ice, 2);
                DrinkGrid.Children.Add(ice);
                ice.Click += new RoutedEventHandler(SelectAddIce);
            }

            if(Drink is Water)
            {
                Button lemon = new Button { Height = 60, Width = 165, Content = "Add Lemon" };
                Grid.SetRow(lemon, 1);
                Grid.SetColumn(lemon, 2);
                DrinkGrid.Children.Add(lemon);
                lemon.Click += new RoutedEventHandler(SelectLemon);

                Button ice = new Button { Height = 45, Width = 165, Content = "Hold Ice" };
                Grid.SetRow(ice, 2);
                Grid.SetColumn(ice, 2);
                DrinkGrid.Children.Add(ice);
                ice.Click += new RoutedEventHandler(SelectHoldIce);
            }

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
