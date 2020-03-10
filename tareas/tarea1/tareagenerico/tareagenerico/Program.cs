﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareagenerico
{
    class Program
    {
       
            static void Main(string[] args)
            {
                // crear un arreglo de int, double y char
                int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8 ,9 };
                double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };
                char[] charArray = { 'H', 'O', 'L', 'A', 'D', 'E' };
                Console.WriteLine("intArray contiene:");
                MuestraArreglo(intArray);
                Console.WriteLine("doubleArray contiene:");
                MuestraArreglo(doubleArray);
                Console.WriteLine("charArray contiene:");
                MuestraArreglo(charArray);
                Console.ReadKey();
            }
            // método genérico para mostrar un arreglo
            private static void MuestraArreglo<T>(T[] arreglo)
            {
                foreach (T elemento in arreglo)
                    Console.Write(elemento + " ");
                Console.WriteLine("\n");
            }
        
    }
}
