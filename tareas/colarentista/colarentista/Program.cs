using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colarentista
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Rent y;
            Cola<Rent> p = new Cola<Rent>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduzca el Nombre: ");
                        String Nombre = Console.ReadLine();
                        Console.Write("Introduzca  Apellidos: ");
                        String apellido = Console.ReadLine();
                        Console.Write("Introduzca sector : ");
                        String sector = Console.ReadLine();
                        Console.Write("Introduzca el Sexo: (M/F) ");
                        String sexo = Console.ReadLine();

                        Console.Write("Introduzca la Edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        y = new Rent(Nombre, apellido, sector, sexo, edad);

                        p.Insertar(y);
                        break;
                    case 2:
                        y = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}" + y);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
