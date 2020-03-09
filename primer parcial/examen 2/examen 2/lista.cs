using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    class lista
    {
        public lista(string eleccion, string Cidudad, int Mas, int CC, int Juntos, int Crecer)
        {
            this.eleccion = eleccion;
            this.Ciudad = Cidudad;
            this.Mas = Mas;
            this.CC = CC;
            this.Juntos = Juntos;
            this.Crecer = Crecer;
        }

        public String eleccion { get; set; }
        public String Ciudad { get; set; }
        public int Mas { get; set; }
        public int CC { get; set; }
        public int Juntos { get; set; }

        public int Crecer { get; set; }
    }
}
