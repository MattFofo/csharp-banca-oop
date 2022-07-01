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

        private List<Client> clientsList = new List<Client>();

        private List<Loan> loansList;



        public Bank(string name)
        {
            this.name = name;
        }


        public static Client CreateClient(string name)
        {
            Client newClient = new Client(name);

            return newClient;
            
        }

        public void AddNewClient(Client client)
        {
            this.clientsList.Add(client);

            Console.WriteLine("hai aggiunto {0} tra i clienti", client.Name);
        }

        public void PrintClientList()
        {
            foreach (var client in this.clientsList)
            {
                Console.WriteLine(client.Name);
            }
        }

        public bool FindClient(Client client)
        {
            if (this.clientsList.Contains(client))
            {
                return true;
            }
            return false;
        }
    }
}
