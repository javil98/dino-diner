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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public CretaceousCombo combo = new CretaceousCombo();

        /// <summary>
        /// Creates a new page of ComboSelection.
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If the datacontext is an order, it will add the entree to both the order and ordercontrol. It also sets the entree to the property.
        /// </summary>
        /// <param name="entree"></param>
        private void SelectCombo(CretaceousCombo combo)
        {
            if (DataContext is Order order)
            {
                order.Add(combo);
                this.combo = combo;
            }
        }

        /// <summary>
        /// An overload contstructor that set the property of the page to the parameter in the constructor.
        /// </summary>
        /// <param name="entree"></param>
        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Adds a Brontowurst to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeBrontowurst(combo, true));
        }

        /// <summary>
        /// Adds a DinoNuggets to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeDinoNuggets(combo, true));
        }

        /// <summary>
        /// Adds a PrehistoricPBJ to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizePrehistoricPBJ(combo, true));

        }

        /// <summary>
        /// Adds a PterodactylWings to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        /// <summary>
        /// Adds a SteakosaurusBurger to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSteakosaurusBurgerCombo(object sender, RoutedEventArgs args)
        {
            CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo, true));
        }

        /// <summary>
        /// Adds a TRexKingBurger to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeTRexKingBurger(combo, true));
        }

        /// <summary>
        /// Adds a VelociWrap to the ordercontrol and order, and also sends the user back to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeVelociWrap(combo, true));
        }
    }
}
