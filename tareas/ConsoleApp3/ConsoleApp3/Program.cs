﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program

    {

        public static void Main()

        {

            double A = 0, B = 1, N, S;

            Console.WriteLine("Rango de Numero Fibonacci");

            N = int.Parse(Console.ReadLine());

            Console.WriteLine("," + A);

            Console.WriteLine("," + B);

            for (int i = 1; i < N; i++)

            {

                S = A + B;

                Console.WriteLine("," + S);

                A = B;

                B = S;

            }

        }

    }
}
