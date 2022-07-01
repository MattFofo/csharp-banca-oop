namespace csharp_banca_oop
{
    internal class Client
    {
        public string Name { get;  set; }
        private string Surname { get; set; }
        private string FiscalCode { get; set; }
        private int Salary { get; set; }


        public Client(string name)
        {
            Name = name;
        }
    }
}