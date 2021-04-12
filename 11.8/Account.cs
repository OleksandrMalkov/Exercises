using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Account
{
    private decimal balance;

    public Account(decimal initialBalance)
    {
        Balance = initialBalance;
    }
    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value >= 0)
                balance = value;
            else
                throw new ArgumentOutOfRangeException("Balance", value, "Balance must be >= 0");
        }
    }
    public virtual void Credit(decimal amount)
    {
        Balance += amount;
        
    }
    public virtual void Debit(decimal withdraw)
    {
        if (withdraw <= Balance)
            Balance -= withdraw;
        else
            throw new ArgumentOutOfRangeException("Withdraw", withdraw, "Debit amount exceeded account balance.");
    }

}
