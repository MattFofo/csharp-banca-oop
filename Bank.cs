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

        public Client FindClient()
        {
            Console.Write("Scrivi nome cliente da cercare:");
            string clientName = Console.ReadLine();

            Client result = null;

            foreach (var client in this.clientsList)
            {
                if (client.Name == clientName)
                {
                    result = client;
                    break;

                }              
            }
            return result;
        }

        public void PrintClientInfo(Client client)
        {
            if (client == null)
            {
                Console.WriteLine("nessun cliente");

            } else
            {
                Console.WriteLine("Nome cliente: " + client.Name);
            }
        }

        public void EditClient(Client client)
        {
            this.PrintClientInfo(client);

            Console.WriteLine("Modifica il nome: ");
            string newName = Console.ReadLine();

            client.Name = newName;

            Console.WriteLine("Info modificate");

            this.PrintClientInfo(client);
        }
    }
}
