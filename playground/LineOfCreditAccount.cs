using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground;

internal class LineOfCreditAccount : BankAccount
{
    public override void PerformMonthEndTransactions()
    {
        if (Balance < 0)
        {
            var interest = -Balance * 0.07m;
            MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
        }
    }
}

