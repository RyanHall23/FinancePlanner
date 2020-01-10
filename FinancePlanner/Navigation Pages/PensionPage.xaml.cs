using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace FinancePlanner.Navigation_Pages
{
    /// <summary>
    /// Interaction logic for PensionPage.xaml
    /// </summary>
    public partial class PensionPage : Page
    {
        COverview ov = new COverview();
        CPension pen = new CPension();

        decimal decExpensesMo;

        public PensionPage()
        {
            InitializeComponent();
            lblDateTime.Content = DateTime.Now.ToShortDateString(); // Sets the Date label to the current Date
            txtPensionMonthlyAmt.Text = pen.GetMonthlyPensionAmount().ToString();
            lblPensionMonthAmt.Content = pen.GetMonthlyPensionAmount();
            lblPensionYearlyAmt.Content = pen.GetYearlyPensionAmount();
        }

        private void BtnConfMonthlyPension_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal.TryParse(txtPensionMonthlyAmt.Text, out decExpensesMo);
                pen.SetMonthlyAndYearlyPension(decExpensesMo);
                ov.SetPension(decExpensesMo);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
    }
}
