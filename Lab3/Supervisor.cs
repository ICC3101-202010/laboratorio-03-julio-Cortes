using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Supervisor:Employee
    {

        public Supervisor(string name, string lastname, string birthday, string nacionality, int money, string rut, int salary, string schedule, string job) : base(name, lastname, birthday, nacionality, money, rut, salary, schedule, job)
        {
        }

        //atributos
        public void AddProduct(List<Product> products)
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string nameproducto = Console.ReadLine();
            string auxproducto = "0";
            int price = 0;
            while (auxproducto != "1")
            {
                Console.WriteLine("Ingrese el precio del producto:");
                string pricestring = Console.ReadLine();
                if (int.TryParse(pricestring, out price))
                {
                    price = Convert.ToInt32(pricestring);
                    auxproducto = "1";
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido\n");
                }
            }
            Console.WriteLine("Ingrese la marca del producto");
            string brand = Console.ReadLine();
            string auxstock = "0";
            int stock = 0;
            while (auxstock != "1")
            {
                Console.WriteLine("Ingrese el stock inicial del producto:");
                string stockstring = Console.ReadLine();
                if (int.TryParse(stockstring, out stock))
                {
                    stock = Convert.ToInt32(stockstring);
                    auxstock = "1";
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido\n");
                }

            }
            Product producto = new Product(nameproducto, price, brand, stock);
            products.Add(producto);

        }
        public void ChangeSalary(Employee employee)
        {
            string auxsalary = "0";
            int salarytemp = 0;
            while (auxsalary != "1")
            {
                Console.WriteLine("A cuanto desea cambiarle el sueldo:");
                string salary = Console.ReadLine();
                if (int.TryParse(salary, out salarytemp))
                {
                    salarytemp = Convert.ToInt32(salary);
                    auxsalary = "1";
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido\n");
                }

            }
            employee.ChangeSalary(salarytemp);
        }
        public void Payment(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                employee.Paymentinf(employee.ReturnSalary());
            }
            Console.WriteLine("Sueldos pagados");
        }
        public void ChangeSchedule(Employee employee)
        {
            Console.WriteLine("Ingrese nuevo horario::");
            employee.Changeschedule(Console.ReadLine());
        }
        public void ChangeJob(Employee employee)
        {
            Console.WriteLine("Ingrese nuevo puesto:");
            employee.Changejob(Console.ReadLine());
        }
    }
   
}
