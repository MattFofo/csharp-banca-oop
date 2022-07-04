using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal abstract class Account
    {
        public Client accountHolder;
        public int balance;
        public int accountId;

        public abstract void Withdraw();

        public abstract void Deposit();
        
        public abstract void FirstDeposit();
        

    }
}
