using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace objekty_i_klasy
{
    internal class Program
    {
        
        
            class samochod
        {
            public string marka { get; set; }
            public int rokprodukcji { get; set; }

            public void opisz()
            {


                Console.WriteLine($"samochod: {marka},rok produkcji {rokprodukcji}");
        }
        }
        static void Main(string[] args) {
            new samochod { marka = "honda", rokprodukcji = 2022 }.opisz();
        }

    }
}
