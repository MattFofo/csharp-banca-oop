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

    }
}
