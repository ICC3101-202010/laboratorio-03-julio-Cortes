using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Person
    {
        private string Rut;
        private string Name;
        private string LastName;
        private string Birthday;
        private int Money;
        List<Product> Cart = new List<Product>();

        //atributos
        public void AddToCart(Product product)
        {
            Cart.Add(product);
            int aux = product.Stock1;
            aux--;
        }
        public void 
        //Metodos
        public Person(string name, string lastname, string birthday, int money, string rut) //constructor
        {
            Rut = rut;
            Name = name;
            LastName = lastname;
            Birthday = birthday;
            Money = money;
        }
        public Person ()//Constructor default
        {
            Rut = "6261890-6";
            Name = "Juan";
            LastName = "Perez";
            Birthday = "28/02/1990";
            Money = 320000;
        }

    }
}
