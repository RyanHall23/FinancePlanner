using System;
using System.Diagnostics;

namespace FinancePlanner.Navigation_Pages
{
    class CPension
    {
        private static decimal s_MonthPension = 0.00m;
        private static decimal s_YearPension = 0.00m;

        /// <summary>
        /// Pension static constructor
        /// </summary>
        static CPension() // Instanciating object
        {
            // Try catch for object creation, if destination is failed to be found
            try
            {
                s_MonthPension = 0; // Initialise value
                s_YearPension = s_MonthPension * 12; ;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        /// <summary>
        /// Sets monthly Pension and yearly pension
        /// </summary>
        /// <param name="a"></param>
        public void SetMonthlyAndYearlyPension(decimal monthly)   // Pass A through to keep members private
        {
            s_MonthPension = monthly;
            s_YearPension = (monthly * 12);    // Set total expenses by multiplying monthly expenses by 12
        }

        /// <summary>
        /// Gets monthly Pension
        /// </summary>
        /// <returns></returns>
        public decimal GetMonthlyPensionAmount()
        {
            return s_MonthPension;
        }

        /// <summary>
        /// Gets Yearly Pension
        /// </summary>
        /// <returns></returns>
        public decimal GetYearlyPensionAmount()
        {
            return s_YearPension;
        }
    }
}
