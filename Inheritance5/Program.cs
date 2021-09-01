using Inheritance5.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Inheritance5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payersList = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i}");
                Console.Write("Individual or company? (i/c)? ");
                char typeOfPayer = char.Parse(Console.ReadLine());

                if (typeOfPayer == 'i')
                {
                    Console.Write("Name: ");
                    string payerName = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());

                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    payersList.Add(new Individual(healthExpenditures, payerName, anualIncome));
                }
                else
                {
                    Console.Write("Name: ");
                    string payerName = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());

                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    payersList.Add(new Company(numberOfEmployees, payerName, anualIncome));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sumTax = 0;
            foreach (TaxPayer payer in payersList)
            {
                sumTax += payer.TotalTax();
                Console.WriteLine(payer.Name
                                    + ": $ "
                                    + payer.TotalTax().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sumTax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
