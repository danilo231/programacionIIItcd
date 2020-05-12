using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    class Zoologico 
    {
        protected string nombre;
        List<Jaula> jaulas; 
       
        protected string direccion;
        protected int telrfono;

        public Zoologico(string nombre,  string direccion, int telefono)
        {
            this.nombre = nombre;
            jaulas = new List<Jaula>();
            this.direccion = direccion;
            this.telrfono = telefono;
        }

    }


}
