using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckingAccount : Account
{
    decimal feePerTransaction;

    public CheckingAccount(decimal fee, decimal accountBalance) : base(accountBalance)
    {
        FeePerTransaction = fee;
    }
    public decimal FeePerTransaction
    {
        get
        {
            return feePerTransaction;
        }
        set
        {
            if (value >= 0)
                feePerTransaction = value;
            else
                throw new ArgumentOutOfRangeException("Fee", value, "Fee per transaction must be >= 0");
        }
    }
    public override void Credit(decimal amount)
    {
        Balance += (amount- FeePerTransaction);
    }
    public override void Debit(decimal withdraw)
    {
        if (withdraw <= Balance - FeePerTransaction)
            Balance -= (withdraw - FeePerTransaction);
        else
            throw new ArgumentOutOfRangeException("Withdraw", withdraw, "Debit amount exceeded account balance.");
    }
}
