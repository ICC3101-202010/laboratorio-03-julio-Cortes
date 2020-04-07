using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Person
    {
        public Person(string name, string lastname, string birthday, string nacionality, int money, string rut) //constructor
        {
            Rut = rut;
            Name = name;
            LastName = lastname;
            Nacionality = nacionality;
            Birthday = birthday;
            Money = money;
        }

        protected string Rut;
        protected string Name;
        protected string LastName;
        protected string Birthday;
        protected string Nacionality;
        protected int Money;
        protected List<Product> Belongings= new List<Product>();
        protected List<Product> Cart = new List<Product>();

        public int Money1 { get => Money; set => Money = value; }
        //atributos
        public string ReturnRut()
        {
            return Rut;
        }
        public List<Product> ReturnCart()
        {
            return Cart;
        }
        public void AddToCart(Product product)
        {
            Cart.Add(product);
            int aux = product.Stock1;
            aux--;
            product.StockChange(aux);
        }
        public virtual List<Product> Buy()
        {
            int aux = Money;
            foreach (Product item in Cart)
            {
                aux -= item.Price1;
            }
            if (aux>=0)
            {
               Console.WriteLine("La compra ha sido exitosa");
                Money = aux;
                foreach (Product item in Cart)
                {
                    Belongings.Add(item);
                }
                Cart.Clear();
               return Cart;
            }
            else
            {
               Console.WriteLine("No alcanzan los fondos, pruebe removiendo algun articulo");
               return Cart;
            }
        }
        public void ReturnToStore(Product product)
        {
            Cart.Remove(product);
            int aux = product.Stock1;
            aux++;
            product.StockChange(aux);
        }
        //Metodos




    }
}
