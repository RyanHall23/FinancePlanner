using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            lblExpensesMonthAmnt.Content = exps.GetMonthExpenses();
            lblExpensesYearlyAmnt.Content = exps.GetYearlyExpenses();
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
