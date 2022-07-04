namespace csharp_banca_oop
{
    internal class Client
    {
        public string Name { get;  set; }
        public string Surname { get; set; }
        public string FiscalCode { get; private set; }
        public int Salary { get; set; }


        public Client(string name, string fiscalCode)
        {
            this.Name = name;
            this.FiscalCode = fiscalCode;
        }

        public static Client CreateClient(string name, string fiscalCode)
        {
            Client newClient = new Client(name, fiscalCode);
            
            Account newAccount = new CheckingAccount(newClient);
            newAccount.FirstDeposit();

            return newClient;

        }

        public void PrintClientInfo(Client client)
        {
            if (client == null)
            {
                Console.WriteLine("nessun cliente");

            }
            else
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
