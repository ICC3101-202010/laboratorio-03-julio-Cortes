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
        public int Money1 { get => Money; set => Money = value; }

        //atributos
        public Person (string rut, string name, string lastname, string birthday, int money) //constructor
        {
            this.Rut = rut;
            this.Name = name;
            this.LastName = lastname;
            this.Birthday = birthday;
            this.Money1 = money;
        }
        public Person ()//Constructor default
        {
            this.Rut = "6261890-6";
            this.Name = "Juan";
            this.LastName = "Perez";
            this.Birthday = "28/02/1990";
            this.Money1 = 320000;
        }

    }
}
