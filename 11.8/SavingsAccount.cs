using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SavingsAccount : Account
{
    private decimal percentage;
    private int months;

    public SavingsAccount(int _months,decimal interestRate, decimal accountBalance) : base(accountBalance)
    {
        Percentage = interestRate;
        Months = _months;
    }
    public int Months
    {
        get
        {
            return months;
        }
        set
        {
            if (value > 0)
                months = value;
            else
                throw new ArgumentOutOfRangeException("Months", value, "Number of months must be > 0");

        }
    }
    public decimal Percentage
    {
        get
        {
            return percentage;
        }
        set
        {
            if (value >= 0)
                percentage = value;
            else
                throw new ArgumentOutOfRangeException("Percentage", value, "Percentage must be >= 0");
        }
    }
    public decimal CalculateInterest()
    {
        return Balance += (Percentage * Balance)* Months;
    }
}
