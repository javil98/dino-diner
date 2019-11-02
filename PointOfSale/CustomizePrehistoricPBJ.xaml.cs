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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ PBJ { get; set; }

        private CretaceousCombo Combo { get; set; }

        private bool IsCombo { get; set; } = false;

        /// <summary>
        /// Creates a new page of CustomizePrehistoricPBJ page.
        /// </summary>
        /// <param name="pbj">The Prehistoric PBJ being stored.</param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.PBJ = pbj;

        }

        /// <summary>
        /// Creates a new page of CustomizeSteakosaurusBurger page, and stores the paremeters into the field properties.
        /// </summary>
        /// <param name="combo">The combo being chosen by the user.</param>
        /// <param name="IsCombo">A boolean that indicates if the page was created by the Combo customization.</param>
        public CustomizePrehistoricPBJ(CretaceousCombo combo, bool IsCombo)
        {
            InitializeComponent();
            this.Combo = combo;
            this.IsCombo = IsCombo;
            this.PBJ = (PrehistoricPBJ) combo.Entree;
        }

        /// <summary>
        /// Holds the Peanut Butter when the hold Peanut Butter button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            PBJ.HoldPeanutButter();
        }

        /// <summary>
        /// Holds the Jelly when the hold Jelly button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            PBJ.HoldJelly();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
