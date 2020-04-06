using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Client:Person
    {
        public Client(string name, string lastname, string birthday, string nacionality, int money, string rut) : base(name, lastname, birthday, nacionality, money, rut)
        {

        }

        public int PriceCheck(Product product)
        {
            return product.Price1;
        }
       public int StockCheck(Product product)
        {
            return product.Stock1;
        }


            
    }
}
