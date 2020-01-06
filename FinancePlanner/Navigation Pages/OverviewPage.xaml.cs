using System;
using System.Windows.Controls;

namespace FinancePlanner.Navigation_Pages
{
    /// <summary>
    /// Interaction logic for OverviewPage.xaml
    /// </summary>
    public partial class OverviewPage : Page
    {
        CIncome income = new CIncome();
        CExpenses expenses = new CExpenses();
        CPension pension = new CPension();
        CSavings savings = new CSavings();
        

        public OverviewPage()
        {
            InitializeComponent();
            lblDateTime.Content = DateTime.Now.ToShortDateString(); // Sets the Date label to the current Date

            lblMarginAmnt.Content = income.GetSalary() - (expenses.GetYearlyExpenses() + pension.GetYearlyPensionAmount() + savings.GetYearlyExpenses());
            // Income
            lblInAmnt.Content = income.GetSalary();

            //Outgoings
            lblOutAmnt.Content = (expenses.GetYearlyExpenses() + pension.GetYearlyPensionAmount() + savings.GetYearlyExpenses());
            lblExpensesAmnt.Content = expenses.GetYearlyExpenses();
            lblPensionAmnt.Content = pension.GetYearlyPensionAmount();
            lblSavingsAmnt.Content = savings.GetYearlyExpenses();

        }
    }
}
