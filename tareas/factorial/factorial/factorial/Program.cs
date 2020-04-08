using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El fibonacci de 3  es {0}", Fibonaci(3));
            Console.WriteLine("El fibonacci recursivo de 3  es {0}", FibonaciRecursiva(3));

            Console.ReadKey();
        }
        static int Fibonaci(int n)
        {
            int aux = 1;
            for (int i = 1; i <= n; i++)
            {
                aux = aux * i;
            }
            return aux;
        }
        static int FibonaciRecursiva(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonaciRecursiva(n - 2) + FibonaciRecursiva(n-1);
        }

    }
}
