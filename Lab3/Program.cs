using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> listofclients = new List<Client>();
            List<Employee> listofemployees = new List<Employee>();
            List<Product> listofproducts = new List<Product>();
            string Default_Stopper = "9";
            Console.WriteLine("Bienvenido al supermercado porfavor eliga una opcion: \n");
            string stopper = "0";
            while (stopper!=Default_Stopper)
            {
                Console.WriteLine("(1)Añadir cliente a la base de datos\n(2)Eliminar cliente de la base de datos\n(3)Ingresar como cliente\n(4)Añadir empleado a la base de datos\n" +
                    "(5)Eliminar empleado de la base de datos\n(6)Ingresar como empleado\n(7)Crear producto\n(8)Eliminar producto \n(9)Salir del programa");
                stopper = Console.ReadLine();
                switch(stopper)
                {
                    case "1":
                        Console.WriteLine("Ingrese el rut con el siguiente formato: 12345678-9");
                        string rut = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento en el siguiente formato: 00/00/0000");
                        string birthday = Console.ReadLine();
                        Console.WriteLine("Ingrese Nacionalidad");
                        string nacionality = Console.ReadLine();
                        Console.WriteLine("Ingrese dinero disponible");
                        int money = Convert.ToInt32(Console.ReadLine());
                        Client client = new Client(name,rut,birthday,nacionality,money,rut);
                        break;
                    case "2":
                        if (listofclients.Count() != 0)
                        {
                            Console.WriteLine("Ingrese el rut con el siguiente formato: 12345678-9");
                            string deleterut = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No existe ningun cliente que eliminar");
                            break;
                        }



                }
            }

        }
    }
}
