//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
//La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)

//I clienti sono caratterizzati da
//nome,
//cognome,
//codice fiscale
//stipendio

//I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.

//Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.
//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

using csharp_banca_oop;

Bank bank1 = new Bank("MPS");

Client client1 = Client.CreateClient("Marco", "M000000");
//Client client2 = Client.CreateClient("Sara", "S000000");
//Client client3 = Client.CreateClient("Federico", "F000000");


bank1.AddNewClient(client1);
//bank1.AddNewClient(client2);
//bank1.AddNewClient(client3);

Account AccountClient1 = client1.GetClientAccount();

client1.PrintBalance();

AccountClient1.Deposit();

client1.PrintBalance();


bank1.PrintClientList();

//Client foundClient = bank1.FindClient("Marco");



//bank1.PrintClientInfo(bank1.FindClient());

//bank1.EditClient(client3);

//Loan loan1 = bank1.CreateLoan();
//Console.WriteLine("interesse: " + loan1.CalculateInterest());


bank1.PrintLoanList();
