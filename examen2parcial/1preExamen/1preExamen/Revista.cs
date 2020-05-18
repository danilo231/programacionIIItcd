using System;
using System.Collections.Generic;
using System.Text;

namespace _1preExamen
{
     class Revista : ClaseLibro
    {
        public Revista(string titulo,int nropagina)
        {
            Titulo = titulo;
            
            Nropagina = nropagina;
        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Nropagina { get; set; }
        override public string ToString()
        {
            return Titulo + " "    + Nropagina + "  ";
        }

    }
}
