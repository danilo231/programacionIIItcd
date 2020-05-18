using System;

namespace _1preExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Pila<ClaseLibro> p = new Pila<ClaseLibro>();
            ClaseLibro z = new ClaseLibro("Libro");
            while (opcion != 4)

            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzc novela");
                        String nombredelibro = Console.ReadLine();
                        Console.WriteLine("introduzca Revista");
                        String autor = Console.ReadLine();
                        Console.WriteLine("introduzca E");
                        String editorial = Console.ReadLine();
                        
                        ClaseLibro a = new ClaseLibro(nombredelibro, autor, editorial);
                        p.push(a);
                        break;
                    case 2:
                        ClaseLibro y = p.pop();
                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
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

