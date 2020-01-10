using System;
using System.Diagnostics;

namespace FinancePlanner.Navigation_Pages
{
    class CExpenses
    {
        private static decimal s_MonthExpenses = 0.00m;
        private static decimal s_YearExpenses = 0.00m;

        /// <summary>
        /// Income static constructor
        /// </summary>
        static CExpenses() // Instanciating object
        {
            // Try catch for object creation, if destination is failed to be found
            try
            {
                s_MonthExpenses = 0; // Initialise value
                s_YearExpenses = s_MonthExpenses * 12; ;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        /// <summary>
        /// Sets monthly expenses & yearly expenses
        /// </summary>
        /// <param name="a"></param>
        public void SetMonthlyAndYearlyExpenses(decimal monthly)   // Pass A through to keep members private
        {
            s_MonthExpenses = monthly;
            s_YearExpenses = (monthly * 12);    // Set total expenses by multiplying monthly expenses by 12
        }

        /// <summary>
        /// Gets monthly expenses
        /// </summary>
        /// <returns></returns>
        public decimal GetMonthExpenses()
        {
            return s_MonthExpenses;
        }

        /// <summary>
        /// Gets Yearly Expenses
        /// </summary>
        /// <returns></returns>
        public decimal GetYearlyExpenses()
        {
            return s_YearExpenses;
        }
    }
}
