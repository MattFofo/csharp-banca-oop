namespace csharp_banca_oop
{
    internal class Client
    {

        public string Name { get;  private set; }
        public string Surname { get; private set; }
        public string FiscalCode { get; private set; }
        public int Salary { get; private set; }

        public List<Account> Accounts = new List<Account>();


        public Client(string name, string fiscalCode)
        {
            this.Name = name;
            this.FiscalCode = fiscalCode;
        }

        public static Client CreateClient(string name, string fiscalCode)
        {
            Client newClient = new Client(name, fiscalCode);

            Console.WriteLine("Select 1 for Checking account"); 
            Console.WriteLine("Select 2 for Saving account");
            int accountChoice = int.Parse(Console.ReadLine());

            if (accountChoice == 1)
            {
                Account newChekingAccount = new CheckingAccount(newClient);
                newClient.Accounts.Add(newChekingAccount);

                newChekingAccount.FirstDeposit();

            } else if (accountChoice == 2) 
            {
                Account newSavingAccount = new SavingAccount(newClient);
                newClient.Accounts.Add(newSavingAccount);

                newSavingAccount.FirstDeposit();

            }

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


        public void PrintBalance()
        {
            foreach (var account in this.Accounts)
            {
                Console.WriteLine(account.GetType());
                Console.WriteLine("Your balance is: " + account.balance);
            }
        }

        public Account GetClientAccount()
        {
            return this.Accounts[0]; //da far funzionare con più accounts
        }
    }

}
