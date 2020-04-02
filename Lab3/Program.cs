using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product bebida = new Product("coca cola", 1000, "ccu", 10);
            Console.WriteLine(bebida.Price1);
            bebida.PriceChange(1500);
            Console.WriteLine(bebida.Price1);
        }
    }
}
