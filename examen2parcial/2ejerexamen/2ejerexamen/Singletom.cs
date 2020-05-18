using System;
using System.Collections.Generic;
using System.Text;

namespace _2ejerexamen
{
    class Singletom
    {
        private static Singletom instance;
        private String Lapaz;
        private String Potosi;
        private String Santa;
        private String Oruro;

        private Singletom()
        {

        }
        public static Singletom getInstance()
        {
            if (instance == null)
            {
                instance = new Singletom();
                return instance;
            }
            else
                return instance;

        }
        public void seta(String valor)
        {
            Oruro = valor;
        }
        public void showMessage()
        {
            Console.WriteLine("hola singleton: " + Oruro);
        }
    }
}
