using System;
using Negozio;
using Negozio12;

namespace Convenienza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il prezzo totale: ");
            double totale = double.Parse(Console.ReadLine());
            double n = ScontoNegozio.Negozio(totale);
            double n12 = ScontoNegozio12.Negozio12(totale);
            if (n < n12)
            {
                Console.WriteLine("E' più conveniente il primo negozio");
            }
            else if (n > n12)
            {
                Console.WriteLine("E' più conveniente il primo negozio");
            }
            else
            {
                Console.WriteLine("Sono ugualmente convenienti");
            }
            Console.ReadLine();
        }
    }
}
