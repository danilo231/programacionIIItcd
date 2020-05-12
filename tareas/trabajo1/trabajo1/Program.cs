using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabajo1;

namespace Fabricadeanimales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Mamiferos f = new Mamiferos();
            while (opcion != 7)
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar Pila");
                Console.WriteLine("2. Eliminar Pila");
                Console.WriteLine("3. Mostrar Pila");
                Console.WriteLine("4. Ingresar Cola");
                Console.WriteLine("5. Eliminar Cola");
                Console.WriteLine("6. Mostrar Cola");
                Console.WriteLine("7. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca valor ");
                        String valor = Console.ReadLine();
                        f.InsertarPila(valor);
                        Console.ReadKey();
                        break;
                    case 2:
                        f.EliminarPila();
                        Console.ReadKey();
                        break;
                    case 3:
                        f.MostrarPila();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Introduzca valor ");
                        valor = Console.ReadLine();
                        f.InsertarCola(valor);
                        Console.ReadKey();
                        break;
                    case 5:
                        f.EliminarCola();
                        Console.ReadKey();
                        break;
                    case 6:
                        f.MostrarCola();
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
