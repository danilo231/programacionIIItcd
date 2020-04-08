using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busqueda_binaria
{
    class Program
    {
        Func<int[], int, int> func = (VECTOR, VALOR) =>
        {
            int inicio = 0;
            int fin = VECTOR.Length - 1;
            int pos;
            while (inicio <= fin)
            {
                pos = (inicio + fin) / 2;
                if (VECTOR[pos] == VALOR)
                {
                    return pos;
                }else if (VECTOR[pos] < VALOR )
                {
                    inicio = pos + 1;
                }
                else
                {
                    fin = pos - 1;
                }
            }
            return -1;
        };
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] VECTOR = { 1, 4, 7, 9, 8, 14, 23, 47 };
            int VALOR = 15;
            int position = obj.func(VECTOR, VALOR);

        }
    }
}
