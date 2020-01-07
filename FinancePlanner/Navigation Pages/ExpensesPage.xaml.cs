using FinancePlanner.Expenditures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace FinancePlanner.Navigation_Pages
{
    /// <summary>
    /// Interaction logic for ExpensesPage.xaml
    /// </summary>
    public partial class ExpensesPage : Page
    {
        COverview ov = new COverview();
        CExpenses exps = new CExpenses();

        decimal decExpensesMo;

        public ExpensesPage()
        {
            InitializeComponent();
            lblDateTime.Content = DateTime.Now.ToShortDateString(); // Sets the Date label to the current Date
            txtExpensesMonthlyAmnt.Text = exps.GetMonthExpenses().ToString();
            lblExpensesMonthAmnt.Content = exps.GetMonthExpenses();
            lblExpensesYearlyAmnt.Content = exps.GetYearlyExpenses();

            CExpense a = new CExpense("",0.00m,false);
        }

        private void BtnCnfmMonthlyExpenses_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal.TryParse(txtExpensesMonthlyAmnt.Text, out decExpensesMo);
                exps.SetMonthlyAndYearlyExpenses(decExpensesMo);
                ov.SetExpense(decExpensesMo);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
    }
}
