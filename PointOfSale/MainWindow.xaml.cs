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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderControl.NavigationService = OrderUI.NavigationService; 
        }

        /// <summary>
        /// When the page is completly loaded, it will set the the data of the frame.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        /// <summary>
        /// When the data context is changed, it will set the frame data context of the page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContext();
        }

        /// <summary>
        /// If the content is not null, it will set the datacontext to the null of the OrderUI DataContext.
        /// </summary>
        private void SetFrameDataContext()
        {
            FrameworkElement content = OrderUI.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderUI.DataContext;
        }

    }
}
