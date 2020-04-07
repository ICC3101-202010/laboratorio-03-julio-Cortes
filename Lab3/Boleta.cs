using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Lab3
{
    class Boleta
    {
        private Employee Employee;
        private Client Client;
        private List<Product> Listofproduct;
        private string Time;
        public Boleta(Employee employee,Client client, List<Product> listofproduct, string time)
        {
            Employee = employee;
            Client = client;
            Listofproduct = listofproduct;
            Time = time;
        }
    }
}
