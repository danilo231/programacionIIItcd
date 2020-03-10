using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
                3, 4, 5, Mayor(3, 4, 5));
            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
               6.6, 8.8, 7.7, Mayor(6.6, 8.8, 7.7));
            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
               "pera", "manzana", "naranja", Mayor("pera", "manzana", "naranja"));
            Console.ReadKey();
        }

       
        private static T Mayor<T>(T x, T y, T z)
            where T : IComparable<T>
        {
            T max = x;
            
            if (y.CompareTo(max) > 0)
                max = y; 
            
            if (z.CompareTo(max) > 0)
                max = z; 
            return max; 
        }
    }
}
