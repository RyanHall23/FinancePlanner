using System;
using System.Diagnostics;

namespace FinancePlanner
{
    class CIncome
    {
        private static decimal s_Salary = 0.00m;
        private static decimal s_MonthSalary = 0.00m;

        /// <summary>
        /// Income static constructor
        /// </summary>
        static CIncome() // Instanciating object
        {
            // Try catch for object creation, if destination is failed to be found
            try
            {
                s_Salary = 0; // Initialise value
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        /// <summary>
        /// Sets salary and divides by 12 to work out Monthly Salary
        /// TODO: Calculate National Insurance and TAX after entering data
        /// </summary>
        /// <param name="salary"></param>
        public void SetSalary(decimal salary)
        {
            s_Salary = salary;
            s_MonthSalary = s_Salary / 12; // TAX TO BE ADDED & NATIONAL INSURANCE
        }

        /// <summary>
        /// Get annual salary
        /// </summary>
        /// <returns></returns>
        public decimal GetSalary()
        {
            return s_Salary;
        }

        /// <summary>
        /// Gets Monthly Salary
        /// </summary>
        /// <returns></returns>
        public decimal GetMonthlySalary()
        {
            return s_MonthSalary;
        }
    }
}
