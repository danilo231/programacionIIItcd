using System;
using System.Collections.Generic;
using System.Text;

namespace _1preExamen
{
    interface ClaseAbstracta
    {
        Novela GetNovela(string titulo, string autor, string genero);
        Revista GetRevista(string titulo, int nropagina);
        Enciclopedia GetEnciclopedia(string nombre, string editorial, string tema);
    }
}
