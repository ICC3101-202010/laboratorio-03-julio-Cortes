using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime localdate = DateTime.Now;
            List<Client> listofclients = new List<Client>();
            List<Employee> listofemployees = new List<Employee>();
            List<Product> listofproducts = new List<Product>();
            List<Boleta> listofchecks = new List<Boleta>();
            List<Supervisor> supervisors = new List<Supervisor>();
            string Default_Stopper = "5";
            string Client_Stoper = "6";
            Console.WriteLine("Bienvenido al supermercado porfavor eliga una opcion:");
            string stopper = "0";
            while (stopper!=Default_Stopper)
            {
                Console.WriteLine("\n(1)Añadir cliente a la base de datos\n(2)Ingresar como cliente\n(3)Añadir empleado a la base de datos\n" +
                    "(4)Ingresar como supervisor \n(5)Salir del programa\n");
                stopper = Console.ReadLine();
                switch(stopper)
                {
                    case "1"://agregar cliente Done
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
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero valido\n");
                            }
                        }
                        Client client = new Client(name,lastname,birthday,nacionality,money,rut);
                        listofclients.Add(client);
                        break;

                    case "2"://Ingresar como cliente Done
                        bool fixer = false;
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
                                    fixer =true;//debugger
                                    string clientstopper = "0";
                                    while (Client_Stoper != clientstopper)
                                    {
                                        Console.WriteLine("\n(1)Agregar producto al carro\n(2)Devolver producto\n(3)Consultar Precio \n(4)Consultar stock\n(5)Finalizar compra\n(6)Volver al menu\n");
                                        clientstopper = Console.ReadLine();
                                        switch (clientstopper)
                                        {
                                            case "1"://d
                                                bool fixer1 = false;
                                                Console.WriteLine("Ingrese el nombre del producto:");
                                                string productname = Console.ReadLine();
                                                if (listofproducts.Count!=0)
                                                {
                                                    foreach (Product product in listofproducts)
                                                    {
                                                        if (product.GetName() == productname)
                                                        {
                                                            fixer1 = true;
                                                            cliente.AddToCart(product);
                                                        }
                                                        break;
                                                    }
                                                    if (fixer1)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No se encontro el producto, intente nuevamente");
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No existen productos en este momento");
                                                    break;
                                                }
 
                                            case "2"://d
                                                bool fixer2 = false;
                                                Console.WriteLine("Ingrese el nombre del producto a devolver:");
                                                string productnamereturn = Console.ReadLine();
                                                if (cliente.ReturnCart().Count()!=0)
                                                {
                                                    foreach (Product product in cliente.ReturnCart())
                                                    {
                                                        if (product.GetName() == productnamereturn)
                                                        {
                                                            fixer2 = true;
                                                            cliente.ReturnToStore(product);
                                                        }
                                                    }
                                                    if (fixer2)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No se encontro el producto, intente nuevamente");
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay productos para devolver");
                                                    break;
                                                }
                                            case "3"://d
                                                bool fixer3 = false;
                                                Console.WriteLine("Ingrese el nombre del producto:");
                                                string productnameprice = Console.ReadLine();
                                                if (listofproducts.Count()!=0)
                                                {
                                                    foreach (Product product in listofproducts)
                                                    {
                                                        if (product.GetName() == productnameprice)
                                                        {
                                                            fixer3 = true;
                                                            Console.WriteLine(cliente.PriceCheck(product));
                                                        }
                                                    }
                                                    if (fixer3)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No se encontro el producto, intente nuevamente");
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay productos para consultar");
                                                    break;
                                                }
                                            case "4"://d
                                                bool fixer4 = false;
                                                Console.WriteLine("Ingrese el nombre del producto:");
                                                string productnamestock = Console.ReadLine();
                                                if (listofproducts.Count() != 0)
                                                {
                                                    foreach (Product product in listofproducts)
                                                    {
                                                        if (product.GetName() == productnamestock)
                                                        {
                                                            fixer4 = true;
                                                            Console.WriteLine(cliente.StockCheck(product));
                                                        }
                                                    }
                                                    if (fixer4)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No se encontro el producto, intente nuevamente");
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay productos para consultar");
                                                    break;
                                                }
                                            case "5"://d
                                                bool fixer5 = false;
                                                if (listofemployees.Count() != 0)
                                                {
                                                    foreach (Employee employee in listofemployees)
                                                    {
                                                        if (employee.ReturnJob() == "Cajero" || employee.ReturnJob() == "cajero")
                                                        {
                                                            fixer5 = true;
                                                            if (cliente.ReturnCart().Count != 0)
                                                            {
                                                                Boleta boleta = new Boleta(employee, cliente, cliente.ReturnCart(), (DateTime.Now.ToString("MM/dd/yyyy")));
                                                                listofchecks.Add(boleta);
                                                                cliente.Buy();
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("El carro esta vacio");
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (fixer5)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No hay empleados con el puesto cajero asignado");
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay empleados para atender como cajero");
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
                                break;
                            }
                            if (fixer) //debugger
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No se encontro el cliente en la base de datos, intente nuevamente\n");
                                break;
                            }
                        }
                        break;
                    case "3"://añadir empleado Done
                        Console.WriteLine("(1)Añadir empleado\n(2)Añadir Supervisor");
                        string suporemp = Console.ReadLine();
                        if (suporemp == "1") 
                        {
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
                            int moneyE = 0;
                            while (auxm != "1")
                            {
                                Console.WriteLine("Ingrese dinero disponible: ");
                                string moneystring = Console.ReadLine();
                                if (int.TryParse(moneystring, out moneyE))
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
                        }
                        else if (suporemp=="2")
                        {
                            Console.WriteLine("Ingrese el rut con el siguiente formato: 12345678-9");
                            string rutS = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre: ");
                            string nameS = Console.ReadLine();
                            Console.WriteLine("Ingrese el apellido: ");
                            string lastnameS = Console.ReadLine();
                            Console.WriteLine("Ingrese fecha de nacimiento en el siguiente formato: 00/00/0000");
                            string birthdayS = Console.ReadLine();
                            Console.WriteLine("Ingrese Nacionalidad: ");
                            string nacionalityS = Console.ReadLine();
                            string auxm = "0";
                            int moneyS = 0;
                            while (auxm != "1")
                            {
                                Console.WriteLine("Ingrese dinero disponible: ");
                                string moneystring = Console.ReadLine();
                                if (int.TryParse(moneystring, out moneyS))
                                {
                                    moneyS = Convert.ToInt32(moneystring);
                                    auxm = "1";
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese un numero valido\n");
                                }
                            }
                            string auxs = "0";
                            int salaryS = 0;
                            while (auxs != "1")
                            {
                                Console.WriteLine("Ingrese el sueldo inicial: ");
                                string salarystring = Console.ReadLine();
                                if (int.TryParse(salarystring, out salaryS))
                                {
                                    salaryS = Convert.ToInt32(salarystring);
                                    auxs = "1";
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese un numero valido\n");
                                }
                            }
                            Console.WriteLine("Ingrese el horario en el siguiente formato: 9:00 a 17:00");
                            string horarioS = Console.ReadLine();
                            Console.WriteLine("Ingrese el puesto de trabajo: ");
                            string jobS = Console.ReadLine();
                            Supervisor supervisor = new Supervisor(nameS, lastnameS, birthdayS, nacionalityS, moneyS, rutS, salaryS, horarioS, jobS);
                            supervisors.Add(supervisor);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                        }

                    case "4"://ingresar como supervisor
                        bool fixer6 = false;
                        Console.WriteLine("Ingrese el rut con el siguiente formato: 12345678-9\n");
                        string rutsup = Console.ReadLine();
                        if (supervisors.Count()==0)
                        {
                            Console.WriteLine("No existen supervisores en la base de datos");
                            break;
                        }
                        else
                        {
                            foreach (Supervisor supervisor in supervisors)
                            {
                                if (supervisor.ReturnRut()==rutsup)
                                {
                                    fixer6 = true;
                                    string Sup_Stopper = "6";
                                    string supswitcher = "0";
                                    while (Sup_Stopper!=supswitcher)
                                    {
                                        Console.WriteLine("(1)Añadir Producto\n(2)Cambiar Salario de empleado\n(3)Pagar sueldos\n(4)Cambiar horario de empleado\n(5)Cambiar puesto de empleado\n(6)Salir");
                                        supswitcher = Console.ReadLine();
                                        switch (supswitcher)
                                        {
                                            case "1"://Anadir product d
                                                supervisor.AddProduct(listofproducts);
                                                break;
                                            case "2 "://Cambiar salario d
                                                bool fixer7 = false;
                                                Console.WriteLine("Ingrese el rut del empleado con el siguiente formato: 12346578-9");
                                                string rutempleado = Console.ReadLine();
                                                if (listofemployees.Count() == 0) 
                                                {
                                                    Console.WriteLine("No se encontraron empleados en la base de datos.\n");
                                                }
                                                else
                                                {
                                                    foreach (Employee employee in listofemployees)//checked
                                                    {
                                                        if (employee.ReturnRut()==rutempleado)
                                                        {
                                                            fixer7 = true;
                                                            supervisor.ChangeSalary(employee);
                                                            break;
                                                        }
                                                    }
                                                    if (fixer7)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No se encontraron empleados en la base de datos.\n");
                                                        break;
                                                    }
                                                }
                                                break;
                                            case "3"://Pagar sueldos
                                                supervisor.Payment(listofemployees);
                                                break;
                                            case "4"://cambiar horario /d
                                                bool fixer8 = false;
                                                Console.WriteLine("Ingrese el rut del empleado con el siguiente formato: 12346578-9");
                                                string rutempleadoH = Console.ReadLine();
                                                if (listofemployees.Count() == 0)
                                                {
                                                    Console.WriteLine("No se encontraron empleados en la base de datos.\n");
                                                }
                                                else
                                                {
                                                    foreach (Employee employee in listofemployees)
                                                    {
                                                        if (employee.ReturnRut() == rutempleadoH)
                                                        {
                                                            fixer8 = true;
                                                            supervisor.ChangeSchedule(employee);
                                                            break;
                                                        }
                                                    }
                                                    if (fixer8)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No se encontraron empleados con ese rut en la base de datos.\n");
                                                        break;
                                                    }
                                                }
                                                break;
                                            case "5"://cambiar puesto /d
                                                bool fixer9 = false;
                                                Console.WriteLine("Ingrese el rut del empleado con el siguiente formato: 12346578-9");
                                                string rutempleadoJ = Console.ReadLine();
                                                if (listofemployees.Count() == 0)
                                                {
                                                    Console.WriteLine("No se encontraron empleados en la base de datos.\n");
                                                }
                                                else
                                                {
                                                    foreach (Employee employee in listofemployees)
                                                    {
                                                        if (employee.ReturnRut() == rutempleadoJ)
                                                        {
                                                            fixer9 = true;
                                                            supervisor.ChangeJob(employee);
                                                            break;
                                                        }
                                                    }
                                                    if (fixer9)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No se encontraron empleados con ese rut en la base de datos.\n");
                                                        break;
                                                    }
                                                }
                                                break;
                                            case "6"://salir
                                                break;
                                            default:
                                                Console.WriteLine("Ingrese una opcion valida");
                                                break;
                                        }
                                    }
                                    
                                    break;
                                }
                                
                            }
                            if (fixer6)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No se encontro ningun supervisor con ese rut");
                                break;
                            }
                        }
                    case "5"://salir
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                        }
                }
            }

        }
    }

