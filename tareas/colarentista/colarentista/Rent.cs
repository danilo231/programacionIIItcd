using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colarentista
{
    class Rent
    {
        

        public String nombre { get; set; }
        public String apellido { get; set; }

        public String sector { get; set; }
        public String sexo { get; set; }

        public int edad { get; set; }

        public Rent(string pnombre, string papellido, string psector, string psexo, int pedad)
        {
            nombre = pnombre;
            apellido = papellido;
            sector = psector;
            sexo = psexo;
            edad = pedad;
        }

        override public string ToString()
        {
            return nombre + "    " + edad.ToString() + "     " + sexo + "     " + sector;
        }


    }
}
