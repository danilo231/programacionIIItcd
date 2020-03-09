using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] intArray = { 2, 3,4 };
            double[] doubleArray = { 3.1, 4.6, 2.3 };
            double[] Array = { -4, -3.2, -6};
            Console.WriteLine("intArray contiene:");
            MuestraArreglo(intArray);
            Console.WriteLine("doubleArray contiene:");
            MuestraArreglo(doubleArray);
            Console.WriteLine("charArray contiene:");
            MuestraArreglo(doubleArray);
            Console.ReadKey();
        }
        private static void MuestraArreglo<T>(T[] arreglo)
        {
            foreach (T elemento in arreglo)
                Console.Write(elemento + " ");
            Console.WriteLine("\n");
        }
        private static void Ordenar<T>(T[] a)
            where T : IComparable<T>
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1 - j; i++)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0)
                    {
                        
                        T aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                        
                    }
                }
            }
        }
    }

    
}
