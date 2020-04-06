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
        public void ChangeSalary(Employee employee, int salary)
        {
            employee.ChangeSalary(salary);
        }
        public void Payment(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                employee.payment(employee.ReturnSalary());
            }
        }
    }
   
}
