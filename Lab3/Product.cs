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
        private readonly string DueDate;
        public int Stock1 { get => Stock; set => Stock = value; }
        public int Price1 { get => Price; set => Price = value; }
        //Atributos
        public int PriceChange(int price)
        {
            this.Price = price;
            return 0;
        }

        //Metodos
        public Product(string name, int price, string brand, int stock, string duedate)
        {
            this.Name = name;
            this.Price = price;
            this.Brand = brand;
            this.Stock = stock;
            this.DueDate = duedate;
        }
        public Product()
        {
            this.Name = "Null";
            this.Price = 0;
            this.Brand = "Null";
            this.Stock = 0;
            this.DueDate = "Null";
        }
        //Constructores
    }
}
