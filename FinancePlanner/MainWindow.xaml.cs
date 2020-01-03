using FinancePlanner.Navigation_Pages;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FinancePlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Intialisation of Window with Overview page being default
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame.Navigate(new OverviewPage());   // Open default Overview page in dock panel
            foreach (MenuItem menuItem in menuPages.Items.OfType<MenuItem>())
            {
                menuItem.Click += MenuItem_Click;
            }
        }

        /// <summary>
        /// Changes the colour of the clicked menu item to show when it is the selected page
        /// https://social.msdn.microsoft.com/Forums/vstudio/en-US/355e32a6-7ced-4fb9-b3c5-00ae1f8a781a/highlight-active-menu?forum=wpf 03/01/2020
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //clear previously set backgrounds...
            foreach (MenuItem menuItem in menuPages.Items.OfType<MenuItem>())
            {
                menuItem.SetValue(MenuItem.BackgroundProperty, null);
                menuItem.SetValue(MenuItem.BorderBrushProperty, null);
            }


            MenuItem mi = sender as MenuItem;
            var converter = new System.Windows.Media.BrushConverter();
            mi.Background = (SolidColorBrush)converter.ConvertFromString("#d54e21");
            mi.BorderBrush = (SolidColorBrush)converter.ConvertFromString("#FF26A0DA");
        }

        /// <summary>
        /// Menu Navigation to traverse the navigation bar and open the corresponding page in the dock panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Menu Navigation
        private void mnubtnOverview_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new OverviewPage());   // Open Overview page in dock panel
        }

        private void mnubtnCurrentMonth_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new CurrentMonthPage());   // Open Current Month page in dock panel
        }

        private void mnubtnCalendar_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new CalendarPage());   // Open Calendar page in dock panel
        }

        private void mnubtnAnnual_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new AnnualPage());   // Open Annual page in dock panel
        }

        private void mnubtnExpenses_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new ExpensesPage());   // Open Expenses page in dock panel
        }

        private void mnubtnSavings_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new SavingsPage());   // Open Savings page in dock panel
        }

        private void mnubtnPension_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new PensionPage());   // Open Pension page in dock panel
        }

        private void mnubtnSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(new SettingsPage());   // Open Settings page in dock panel
        }
        #endregion
    }
}
