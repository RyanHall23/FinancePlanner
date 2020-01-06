using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace FinancePlanner.Navigation_Pages
{
    /// <summary>
    /// Interaction logic for SavingsPage.xaml
    /// </summary>
    public partial class SavingsPage : Page
    {
        COverview ov = new COverview();
        CSavings svgs = new CSavings();

        decimal decExpensesMo;

        public SavingsPage()
        {
            InitializeComponent();
            lblDateTime.Content = DateTime.Now.ToShortDateString(); // Sets the Date label to the current Date
            txtSavingsMonthlyAmnt.Text = svgs.GetMonthSavings().ToString();
            lblSavingsMonthAmnt.Content = svgs.GetMonthSavings();
            lblSavingsYearlyAmnt.Content = svgs.GetYearlyExpenses();
        }

        private void BtnCnfmMonthlyExpenses_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal.TryParse(txtSavingsMonthlyAmnt.Text, out decExpensesMo);
                svgs.SetMonthlyAndYearlySavings(decExpensesMo);
                ov.SetExpense(decExpensesMo);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
    }
}
