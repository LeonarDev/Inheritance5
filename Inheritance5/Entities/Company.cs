namespace Inheritance5.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualIncome)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public Company()
        {
        }

        public override double TotalTax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
