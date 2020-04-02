using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Product
    {
        private readonly string Name;
        private int Price;
        private readonly string Brand;
        private int Stock;


        public int Stock1 { get => Stock; }
        public int Price1 { get => Price; }

        //Atributos
        public void PriceChange(int price)
        {
            Price = price;
        }
        public void StockChange(int stock)
        {
            Stock = stock;
;        }


        //Metodos
        public Product(string name, int price, string brand, int stock)
        {
            Name = name;
            Price = price;
            Brand = brand;
            Stock = stock;
        }
        public Product()
        {
            Name = "Null";
            Price = 0;
            Brand = "Null";
            Stock = 0;
        }
        //Constructores
    }
}
