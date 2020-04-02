using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Employee:Client
    {
        private int Salary;
        private string Schedule;
        private string Job;
        //atributos
        public void Changejob(Employee empleado1, Employee empleado2)
        {
            string aux = empleado1.Job;
            string aux1 = empleado2.Job;
            empleado1.Job = aux1;
            empleado2.Job = aux;
        }
        public void Changejob(string job)
        {
            Job = job;
        }
        public void Changeschedule(Employee empleado1, Employee empleado2)
        {
            string aux = empleado1.Schedule;
            string aux1 = empleado2.Schedule;
            empleado1.Schedule = aux1;
            empleado2.Schedule = aux;
        }
        public void Changeschedule(string schedule)
        {
            Schedule = schedule;
        }
        public new List<Product> Buy()
        {
            int aux = Money;
            foreach (Product item in Cart)
            {
                aux -= (item.Price1)*(70/100);
            }
            if (aux >= 0)
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
    }
}
