using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarearepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, num = 0;
            Console.WriteLine("Cuantos numeros va ingresar");
            int numeros = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite un numero:");
                num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    m = num;
                }
                if (num > m)
                {
                    m = num;
                }
                else
                {
                    Console.WriteLine("numeros:");
                }
                
            }
            Console.WriteLine("numero mayor es:" + m);
        }
    }
}
