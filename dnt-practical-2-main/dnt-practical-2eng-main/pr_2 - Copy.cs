using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Km, Wg, Charge;
            Console.WriteLine("Enter the value of Km");
            Km = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Wg");
            Wg = int.Parse(Console.ReadLine());
            if (Km <= 100)
            {
                Charge = 50 * Wg;
            }
            else if (Km >100 && Km <= 200)
            {
                Charge = 65 * Wg;
            }
            else if (Km > 200 && Km <= 300)
            {
                Charge = 90 * Wg;
            }
            else
            {
                Charge = 120 * Wg;
            }
            Console.WriteLine("Charge =" + Charge);
            Console.ReadLine();

        }
    }
}
