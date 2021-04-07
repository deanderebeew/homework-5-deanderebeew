using System;
using System.IO;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] customernames = new string[1000];


            double[] accountbalances = new double[1000];

            string[] namelines = File.ReadAllLines("CustomerNames.CSV");
            string[] balancesLines = File.ReadAllLines("AccountBalances.CSV");

            for (int i = 1; i < namelines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(namelines[i]) == true)
                {
                    continue;
                }

                customernames[i - 1] = namelines[i];

                string balance = balancesLines[i];
                balance = balance.Replace("$", "");
                accountbalances[i - 1] = Convert.ToDouble(balance);

            }


            Console.WriteLine("Whose account do you want to look up? >>");
            foreach (string name in customernames)
            {
                Console.WriteLine(name);
            }

            string answer = Console.ReadLine();

            Console.WriteLine();
            for (int i = 0; i < customernames.Length; i++)
            {
                if (answer.ToLower() == customernames[i].ToLower())
                {
                    Console.WriteLine($"{answer} has a balance of {accountbalances[i].ToString("C")}");
                }
            }
        }
    }
}
