using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrukcje_warunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wiek = 18;
            if (wiek >= 18)
            {
                Console.WriteLine("Jesteś pełnoletni.");
            }
            else
            {
                Console.WriteLine("Nie jesteś pełnoletni.");
            }

        }
    }
}
