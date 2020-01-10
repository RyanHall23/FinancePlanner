namespace FinancePlanner
{
    class COverview
    {
        private static decimal s_Margin;     // Yearly
        private static decimal s_Income;     // Yearly
        private static decimal s_TotalOut;   // Total = Income - (Expense + Savings + Pension)
        private static decimal s_Expense;    // Monthly
        private static decimal s_Savings;    // Monthly
        private static decimal s_Pension;    // Monthly

        static COverview() // Instanciating object
        {
            // Create
        }

        // Margin
        public static void SetMargin(decimal a)
        {
            s_Margin = a;
        }

        public static decimal GetMargin()
        {
            return s_Margin;
        }

        // Income
        public void SetIncome(decimal a)
        {
            s_Income = a;
        }
        public decimal GetIncome()
        {
            return s_Income;
        }

        // Total Out
        public void SetTotalOut(decimal a)
        {
            s_TotalOut = a;
        }

        public decimal GetTotalOut()
        {
            return s_TotalOut;
        }

        // Expenses
        public void SetExpense(decimal a)
        {
            s_Expense = a;
        }

        public decimal GetExpenses()
        {
            return s_Expense;
        }

        // Savings
        public void SetSavings(decimal a)
        {
            s_Savings = a;
        }

        public decimal GetSavings()
        {
            return s_Savings;
        }

        // Pension
        public void SetPension(decimal a)
        {
            s_Pension = a;
        }

        public decimal GetPension()
        {
            return s_Pension;
        }
    }
}
