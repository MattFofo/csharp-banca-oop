namespace csharp_banca_oop
{
    public interface IInterest
    {
        public int InteressiSulTot { get; set; }
        public int CalculateInterest();
        
    }
    internal class Loan : IInterest
    {
        private int ID { get; set; }
        private Client Borrower { get; set; }
        private int totalDue { get; set; }
        private int Instalment { get; set; }
        private DateTime StartLoan { get; set; }
        private DateTime EndLoan { get; set; }
        public int InteressiSulTot { get; set; }

        public Loan(int iD, Client borrower, int totalDue, int instalment, DateTime startLoan, DateTime endLoan)
        {
            this.ID = iD;
            this.Borrower = borrower;
            this.totalDue = totalDue;
            this.Instalment = instalment;
            this.StartLoan = startLoan;
            this.EndLoan = endLoan;
        }

        public void PrintLoanInfo()
        {
            Console.WriteLine("ID: " + this.ID);

            if (this.Borrower == null)
            {
                Console.WriteLine("codice fiscale non è associato a nessun cliente");
            }else
            {
                Console.WriteLine("Borrower Fiscal Code: " + this.Borrower.FiscalCode);
            }

            Console.WriteLine("Data inizio: " + this.StartLoan);
            Console.WriteLine("Data fine: " + this.EndLoan);

            Console.WriteLine("Ammontare prestito: " + (this.totalDue + this.InteressiSulTot));
            Console.WriteLine("Rata: " + this.Instalment);

        }

        public int CalculateInterest()
        {
            Console.WriteLine("inserisci tasso di interesse");
            int interest = int.Parse(Console.ReadLine());

            return this.InteressiSulTot = this.totalDue * interest / 100;
        }


    }
}
