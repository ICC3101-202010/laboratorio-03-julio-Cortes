using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Employee : Client
    {
        private int Salary;
        protected string Schedule;
        protected string Job;

        public Employee(string name, string lastname, string birthday, string nacionality, int money, string rut, int salary, string schedule,string job) : base(name, lastname, birthday, nacionality, money, rut)
        {
            this.Salary = salary;
            this.Schedule = schedule;
            this.Job = job;
        }

        //atributos

        public void Changejob(string job)
        {
            Job = job;
            
        }
        public void Changeschedule(string schedule)
        {
            Schedule = schedule;
        }
        public void ChangeSalary(int salary)
        {
            this.Salary = salary;
        }
        public int ReturnSalary()
        {
            return Salary;
        }
        public void Paymentinf(int money)
        {
            Money += money;
        }
        public string ReturnJob()
        {
            return Job;
        }
    }
}
