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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Gets and sets a Side
        /// </summary>
        public Side Side { get; set; }
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// An overload constructor that initializes a side.
        /// </summary>
        /// <param name="side">Side being added to the page</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        /// <summary>
        /// Adds a side and sets the side to the page so as long the datacontext is an order.
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                this.Side = side;
            }
        }

        /// <summary>
        /// Adds a frycertitops to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
            
        }

        /// <summary>
        /// Adds a MezzorellaSticks to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {

            SelectSide(new MezzorellaSticks());

        }

        /// <summary>
        /// Adds a MeteorMacAnCheese to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMeteorMacAnCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());

        }

        /// <summary>
        /// Adds a Triceritots to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());

        }

        /// <summary>
        /// Sets the side of the of side so as along as the side isn't null.
        /// </summary>
        /// <param name="size"></param>
        public void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side!=null)
            this.Side.Size = size;
        }

        /// <summary>
        /// Sets the size of the side to small and takes the user back to the MenuCategroySelection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the size of the side to Medium and takes the user back to the MenuCategroySelection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Sets the size of the side to Large and takes the user back to the MenuCategroySelection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        { 
            SelectSize(DinoDiner.Menu.Size.Large);
        }




    }
}
