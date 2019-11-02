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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        DinoNuggets Nuggets { get; set; }

        private bool IsCombo { get; set; } = false;

        private CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Creates a new CustomizeDinoNuggets page.
        /// </summary>
        public CustomizeDinoNuggets()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new CustomizeDinoNuggets page, ands stores the parameter into the field property.
        /// </summary>
        /// <param name="nuggets"></param>
        public CustomizeDinoNuggets(DinoNuggets nuggets)
        {
            InitializeComponent();
            this.Nuggets = nuggets;
       
        }

        /// <summary>
        /// Creates a new page of CustomizeDinoNuggets page, and stores the paremeters into the field properties.
        /// </summary>
        /// <param name="combo">The combo choosen by the user.</param>
        /// <param name="IsCombo">A boolean that indicates if the page was created by the Combo customization.</param>
        public CustomizeDinoNuggets(CretaceousCombo combo, bool IsCombo)
        {
            InitializeComponent();
            this.Combo = combo;
            this.IsCombo = IsCombo;
            this.Nuggets = (DinoNuggets) combo.Entree;
        }

        /// <summary>
        /// Adds a nugget to the DinoNuggets when the add nugget button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnAddNugget(object sender, RoutedEventArgs args)
        {
            Nuggets.AddNugget();
        }

        /// <summary>
        /// Will navigate to the Customize page if IsCombo is true. If false, it will go to Menu Catergory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (IsCombo)
            {
                NavigationService.Navigate(new CustomizeCombo(Combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
