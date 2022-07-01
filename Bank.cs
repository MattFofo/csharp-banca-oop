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

        private List<Loan> loansList = new List<Loan>();



        public Bank(string name)
        {
            this.name = name;
        }


        public static Client CreateClient(string name, string fiscalCode)
        {
            Client newClient = new Client(name, fiscalCode);

            return newClient;
            
        }

        public void CreateLoan()
        {
            Console.WriteLine("Creazione nuovo prestito");

            Console.WriteLine("Inserisci Codice Fiscale Cliente: ");
            string borrowerFiscalCode = Console.ReadLine();

            Client borrower = this.FindClient(borrowerFiscalCode);

            Console.WriteLine("Inserisci ammontare prestito:");
            int totalDue = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci rata:");
            int instalment = int.Parse(Console.ReadLine());

            Console.WriteLine("Data inizio prestito:");
            DateTime startLoan = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Data inizio prestito:");
            DateTime endLoan = DateTime.Parse(Console.ReadLine());

            Random random = new Random();
            int iD = random.Next(1, 999999999); //TODO: controllo per renderlo unico

            Loan loan = new Loan(iD, borrower, totalDue, instalment, startLoan, endLoan);

            this.AddNewLoan(loan);

            Console.WriteLine("prestito creato.");
            Console.WriteLine("prestito info:");

            loan.PrintLoanInfo();
        }

        public void AddNewLoan(Loan loan)
        {
            this.loansList.Add(loan);

            Console.WriteLine("hai aggiunto un nuovo prestito");
        }

        public void PrintLoanList()
        {
            Console.WriteLine("Loans List:");
            foreach (var loan in loansList)
            {
                Console.WriteLine("************");
                loan.PrintLoanInfo();
                Console.WriteLine("************");

            }
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
            string clientFiscalCode = Console.ReadLine();

            Client result = null;

            foreach (var client in this.clientsList)
            {
                if (client.FiscalCode == clientFiscalCode)
                {
                    result = client;
                    break;

                }              
            }
            return result;
        }

        public Client FindClient(string fiscalCode)
        {
            Client result = null;

            foreach (var client in this.clientsList)
            {
                if (client.FiscalCode == fiscalCode)
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
