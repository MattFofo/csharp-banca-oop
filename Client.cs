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
    }
}