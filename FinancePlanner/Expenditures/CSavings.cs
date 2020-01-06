using System;
using System.Diagnostics;

namespace FinancePlanner.Navigation_Pages
{
    class CSavings
    {
        private static decimal s_MonthSavings = 0.00m;
        private static decimal s_YearSavings = 0.00m;

        /// <summary>
        /// Savings static constructor
        /// </summary>
        static CSavings() // Instanciating object
        {
            // Try catch for object creation, if destination is failed to be found
            try
            {
                s_MonthSavings = 0; // Initialise value
                s_YearSavings = s_MonthSavings * 12; ;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        /// <summary>
        /// Sets monthly and yearly savings
        /// </summary>
        /// <param name="a"></param>
        public void SetMonthlyAndYearlySavings(decimal monthly)   // Pass A through to keep members private
        {
            s_MonthSavings = monthly;
            s_YearSavings = (monthly * 12);    // Set total expenses by multiplying monthly expenses by 12
        }

        /// <summary>
        /// Gets monthly savings
        /// </summary>
        /// <returns></returns>
        public decimal GetMonthSavings()
        {
            return s_MonthSavings;
        }

        /// <summary>
        /// Gets yearly savings
        /// </summary>
        /// <returns></returns>
        public decimal GetYearlyExpenses()
        {
            return s_YearSavings;
        }
    }
}
