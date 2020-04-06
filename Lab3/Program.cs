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
            string Default_Stopper = "7";
            string Client_Stoper = "6";
            Console.WriteLine("Bienvenido al supermercado porfavor eliga una opcion:");
            string stopper = "0";
            while (stopper!=Default_Stopper)
            {
                Console.WriteLine("\n(1)Añadir cliente a la base de datos\n(2)Ingresar como cliente\n(3)Añadir empleado a la base de datos\n" +
                    "(4)Ingresar como empleado\n(5)Crear producto\n(6)Eliminar producto \n(7)Salir del programa\n");
                stopper = Console.ReadLine();
                switch(stopper)
                {
                    case "1"://agregar cliente
                        Console.WriteLine("Ingrese el rut con el siguiente formato: 12345678-9");
                        string rut = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido: ");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento en el siguiente formato: 00/00/0000");
                        string birthday = Console.ReadLine();
                        Console.WriteLine("Ingrese Nacionalidad: ");
                        string nacionality = Console.ReadLine();
                        string auxcliente = "0";
                        int money = 0;
                        while (auxcliente != "1")
                        {
                            Console.WriteLine("Ingrese dinero disponible: ");
                            string moneystring = Console.ReadLine();
                            if (int.TryParse(moneystring, out money))
                            {
                                money = Convert.ToInt32(moneystring);
                                auxcliente= "1";
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero valido\n");
                            }
                        }
                        Client client = new Client(name,rut,birthday,nacionality,money,rut);
                        listofclients.Add(client);
                        break;

                    case "2"://Ingresar como cliente
                        if (listofclients.Count()==0)
                        {
                            Console.WriteLine("No existen clientes en la base de datos");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese el rut con el siguiente formato: 12345678-9\n");
                            string rutclient = Console.ReadLine();
                            foreach (Client cliente in listofclients)
                            {
                                if (cliente.ReturnRut() == rutclient)
                                {
                                    string clientstopper = "0";
                                    while (Client_Stoper != clientstopper)
                                    {
                                        Console.WriteLine("(1)Agregar producto al carro\n(2)Devolver producto\n(3)Consultar Precio \n(4)Consultar stock\n(5)Finalizar compra\n(6)Volver al menu\n");
                                        clientstopper = Console.ReadLine();
                                        switch (clientstopper)
                                        {
                                            case "1"://debugged
                                                Console.WriteLine("Ingrese el nombre del producto:");
                                                string productname = Console.ReadLine();
                                                if (listofproducts.Count!=0)
                                                {
                                                    foreach (Product product in listofproducts)
                                                    {
                                                        if (product.GetName() == productname)
                                                        {
                                                            cliente.AddToCart(product);
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("No se encontro el producto, intente nuevamente\n");
                                                        }
                                                    }
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No existen productos en este momento");
                                                    break;
                                                }
 
                                            case "2"://debugged
                                                Console.WriteLine("Ingrese el nombre del producto a devolver:");
                                                string productnamereturn = Console.ReadLine();
                                                if (cliente.ReturnCart().Count()!=0)
                                                {
                                                    foreach (Product product in cliente.ReturnCart())
                                                    {
                                                        if (product.GetName() == productnamereturn)
                                                        {
                                                            cliente.ReturnToStore(product);
                                                            Console.WriteLine("No se encontro el producto, intente nuevamente\n");
                                                        }
                                                    }
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay productos para devolver");
                                                    break;
                                                }

                                            case "3"://debugged
                                                Console.WriteLine("Ingrese el nombre del producto:");
                                                string productnameprice = Console.ReadLine();
                                                if (listofproducts.Count()!=0)
                                                {
                                                    foreach (Product product in listofproducts)
                                                    {
                                                        if (product.GetName() == productnameprice)
                                                        {
                                                            Console.WriteLine(cliente.PriceCheck(product));
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("No se encontro el producto, intente nuevamente\n");
                                                        }
                                                    }
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay productos para consultar");
                                                    break;
                                                }
                                            case "4"://debugged
                                                Console.WriteLine("Ingrese el nombre del producto:");
                                                string productnamestock = Console.ReadLine();
                                                if (listofproducts.Count() != 0)
                                                {
                                                    foreach (Product product in listofproducts)
                                                    {
                                                        if (product.GetName() == productnamestock)
                                                        {
                                                            Console.WriteLine(cliente.StockCheck(product));
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("No se encontro el producto, intente nuevamente\n");
                                                        }
                                                    }
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay productos para consultar");
                                                    break;
                                                }
                                            case "5"://debugged
                                                if (cliente.ReturnCart().Count != 0)
                                                {
                                                    cliente.Buy();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("El carro esta vacio");
                                                    break;
                                                }

                                            case "6":
                                                break;
                                            default:
                                                Console.WriteLine("Ingrese una opcion valida");
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No se encontro el cliente en la base de datos, intente nuevamente\n");

                                }
                            }
                       
                        }
                        break;
                    case "3"://añadir empleado
                        Console.WriteLine("Ingrese el rut con el siguiente formato: 12345678-9");
                        string rutE = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre: ");
                        string nameE = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido: ");
                        string lastnameE = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento en el siguiente formato: 00/00/0000");
                        string birthdayE = Console.ReadLine();
                        Console.WriteLine("Ingrese Nacionalidad: ");
                        string nacionalityE = Console.ReadLine();
                        string auxm = "0";
                        int moneyE=0;
                        while (auxm!="1")
                        {
                            Console.WriteLine("Ingrese dinero disponible: ");
                            string moneystring = Console.ReadLine();
                            if (int.TryParse(moneystring,out moneyE))
                            {
                                moneyE = Convert.ToInt32(moneystring);
                                auxm = "1";
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero valido\n");
                            }
                        }
                        string auxs = "0";
                        int salary = 0;
                        while (auxs != "1")
                        {
                            Console.WriteLine("Ingrese el sueldo inicial: ");
                            string salarystring = Console.ReadLine();
                            if (int.TryParse(salarystring, out moneyE))
                            {
                                salary = Convert.ToInt32(salarystring);
                                auxs = "1";
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero valido\n");
                            }
                        }
                        Console.WriteLine("Ingrese el horario en el siguiente formato: 9:00 a 17:00");
                        string horario = Console.ReadLine();
                        Console.WriteLine("Ingrese el puesto de trabajo: ");
                        string job = Console.ReadLine();
                        Employee empleado = new Employee(nameE, lastnameE, birthdayE, nacionalityE, moneyE, rutE, salary, horario, job);
                        listofemployees.Add(empleado);
                        break;
                    case "4"://ingresar como empleado

                        break;


                    






                }
            }

        }
    }
}
