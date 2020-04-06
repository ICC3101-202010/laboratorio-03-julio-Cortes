using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Product
    {
        public Product(string name, int price, string brand, int stock)
        {
            Name = name;
            Price = price;
            Brand = brand;
            Stock = stock;
        }//Constructor

        private readonly string Name;
        private int Price;
        private readonly string Brand;
        private int Stock;//Atributos


        public int Stock1 { get => Stock; }
        public int Price1 { get => Price; }

    
        public void PriceChange(int price)
        {
            Price = price;
        }
        public void StockChange(int stock)
        {
            Stock = stock;
        }
        public string getName()
        {
            return Name;
        }
        //Metodos


    }
}
