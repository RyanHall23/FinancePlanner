using FinancePlanner.Navigation_Pages;
using System.Windows;

namespace FinancePlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame.Navigate(new OverviewPage());   // Open default Overview page in dock panel
        }

        private void NavigationFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)  // After frame(page) is navigated to
        {

        }
    }
}
