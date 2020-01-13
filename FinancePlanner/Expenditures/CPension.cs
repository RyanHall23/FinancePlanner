using System;
using System.Diagnostics;

namespace FinancePlanner.Navigation_Pages
{
    class CPension
    {
        private static decimal s_MonthPension = 0.00m;
        private static decimal s_YearPension = 0.00m;
        private static double  s_PercentPension = 0;

        /// <summary>
        /// Pension static constructor
        /// </summary>
        static CPension() // Instanciating object
        {
            // Try catch for object creation, if destination is failed to be found
            try
            {
                // Initialise value

                s_MonthPension = 0; 
                s_YearPension = 0 ;
                s_PercentPension = 0;
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
        public void SetMonthlyAndYearlyPension(double percentage)   // Pass A through to keep members private
        {
            COverview ov = new COverview();
            ov.SetPensionPer(percentage);
            //Calculate income from percentage paid to pension and copy to overview Class

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
