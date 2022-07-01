using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Bank
    {
        private string name { get; set; }

        private List<Client> clientsList;

        private List<Loan> loansList;
    }
}
