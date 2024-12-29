using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przywitanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("jak masz na imie");
            string tekst = Console.ReadLine();
            Console.WriteLine($"czesc {tekst}");
        }
    }
}
