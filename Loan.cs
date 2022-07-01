namespace csharp_banca_oop
{
    internal class Loan
    {
        private int ID { get; set; }
        private Client Borrower { get; set; }
        private int totalDue { get; set; }
        private int Instalment { get; set; }
        private DateTime StartLoan { get; set; }
        private DateTime EndLoan { get; set; }


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
            Console.WriteLine("Borrower Fiscal Code: " + this.Borrower.FiscalCode);
            Console.WriteLine("Ammontare prestito: " + this.totalDue);
            Console.WriteLine("Rata: " + this.Instalment);

        }
    }
}
