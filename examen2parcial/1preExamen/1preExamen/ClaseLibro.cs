using System;
using System.Collections.Generic;
using System.Text;

namespace _1preExamen
{
   abstract class ClaseLibro:ClaseAbstracta
    {
        protected string Nombre;
        List<Revista> revistas;
        List<Novela> novelas;
        List<Enciclopedia> enciclopedias;

        protected ClaseLibro(string nombre, List<Revista> revistas, List<Novela> novelas, List<Enciclopedia> enciclopedias)
        {
            Nombre = nombre;
            this.revistas = revistas;
            this.novelas = novelas;
            this.enciclopedias = enciclopedias;
        }

        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }


        public Enciclopedia GetEnciclopedia(string nombre, string editorial, string tema)
        {
            throw new NotImplementedException();
        }

        public Novela GetNovela(string titulo, string autor, string genero)
        {
            throw new NotImplementedException();
        }

        public Revista GetRevista(string titulo, int nropagina)
        {
            throw new NotImplementedException();
        }
    }
}
