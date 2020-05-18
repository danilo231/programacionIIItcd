using System;
using System.Collections.Generic;
using System.Text;

namespace _1preExamen
{
    class Enciclopedia :ClaseLibro
    {
        public Enciclopedia(string nombre, string editorial, string tema)
        {
            Nombre = Nombre;
            
            Editorial = editorial;
            Tema = tema;
        }

        public string Nombre { get; set; }
       
        public string Editorial { get; set; }
        public string Tema { get; set; }

        override public string ToString()
        {
            return Nombre + " " + Editorial + "  " + Tema + "  ";
        }
    }
}
