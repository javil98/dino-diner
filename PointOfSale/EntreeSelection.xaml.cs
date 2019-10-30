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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Gets and sets a Entree.
        /// </summary>
        public Entree Entree { get; set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If the datacontext is an order, it will add the entree to both the order and ordercontrol. It also sets the entree to the property.
        /// </summary>
        /// <param name="entree"></param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
        }

        /// <summary>
        /// An overload contstructor that set the property of the page to the parameter in the constructor.
        /// </summary>
        /// <param name="entree"></param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        /// <summary>
        /// Adds a Brontowurst to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            Brontowurst bw = new Brontowurst();
            SelectEntree(bw);
            NavigationService.Navigate(new CustomizeBrontowurst(bw));
        }

        /// <summary>
        /// Adds a DinoNuggets to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            DinoNuggets nuggets = new DinoNuggets();
            SelectEntree(nuggets);
            NavigationService.Navigate(new CustomizeDinoNuggets(nuggets));
        }

        /// <summary>
        /// Adds a PrehistoricPBJ to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            SelectEntree(pbj);
            NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            
        }

        /// <summary>
        /// Adds a PterodactylWings to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Adds a SteakosaurusBurger to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            SelectEntree(burger);
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(burger));
        }

        /// <summary>
        /// Adds a TRexKingBurger to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            TRexKingBurger burger = new TRexKingBurger();
            SelectEntree(burger);
            NavigationService.Navigate(new CustomizeTRexKingBurger(burger));
        }

        /// <summary>
        /// Adds a VelociWrap to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            VelociWrap wrap = new VelociWrap();
            SelectEntree(wrap);
            NavigationService.Navigate(new CustomizeVelociWrap(wrap));
        }

    }
}
