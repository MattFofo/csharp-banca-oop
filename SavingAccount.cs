using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class SavingAccount : Account
    {
        public SavingAccount(Client accountHolder) : base(accountHolder)
        {
            this.accountHolder = accountHolder;
        }
        public override void Deposit()
        {
            Console.WriteLine("Quanto depositi? (massimo 5000euro)");
            int deposit = int.Parse(Console.ReadLine());

            if (deposit > 5000)
            {
                Console.WriteLine("Troppi soldi, non li vogliamo");
                this.Deposit();
            } else
            {

                this.balance += deposit;

                Console.WriteLine("Deposit succesful! New balance: " + this.balance);
            }

        }


        public override void Withdraw()
        {
            Console.WriteLine("Quanto prelievi? (devi avere almeo 1000euro sul conto)");
            int withdraw = int.Parse(Console.ReadLine());

            if ((this.balance - withdraw) < 1000)
            {
                Console.WriteLine("Saldo insufficiente");
                this.Withdraw();
            }
            else
            {
                this.balance -= withdraw;
            }

            Console.WriteLine("Withdraw succesful! New balance: " + this.balance);
        }


        public override void FirstDeposit()
        {
            Console.WriteLine("Inserisci deposito iniziale: ");
            int firstDeposit = int.Parse(Console.ReadLine());

            if (firstDeposit <= 50)
            {
                Console.WriteLine("barbone metti almeno 50euri");
                this.FirstDeposit();
            }
            else
            {
                this.balance = firstDeposit;
            }
        }
    }
}

