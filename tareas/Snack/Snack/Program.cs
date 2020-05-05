using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoSimple carne = new ProductoSimple("Carne", 4, "carne");
            ProductoSimple tomate = new ProductoSimple("tomate", 0.5, "tomate");

            ProductoSimple lechuga = new ProductoSimple("lechuga", 0.5, "lechuga");
            ProductoSimple tocino = new ProductoSimple("tocino", 2, "tocino");

            ProductoSimple soda = new ProductoSimple("soda", 2, "soda");
            ProductoSimple papasfritas = new ProductoSimple("papasfritas", 1.5, "papafritas");

            ProductoSimple queso = new ProductoSimple("queso", 1, "queso");



            ProductoCompuesto simple = new ProductoCompuesto("Simple");
            simple.insertarProducto(carne);
            simple.insertarProducto(tomate);
            simple.insertarProducto(lechuga);



            ProductoCompuesto casaPC = new ProductoCompuesto("de queso");
            casaPC.insertarProducto(carne);
            casaPC.insertarProducto(tomate);
            casaPC.insertarProducto(lechuga);
            casaPC.insertarProducto(queso);

            ProductoCompuesto hamburguesaD = new ProductoCompuesto("de queso");
            hamburguesaD.insertarProducto(carne);
            hamburguesaD.insertarProducto(carne);
            hamburguesaD.insertarProducto(tomate);
            hamburguesaD.insertarProducto(lechuga);
            hamburguesaD.insertarProducto(queso);

            ProductoCompuesto hamburguesaT = new ProductoCompuesto("de queso");
            hamburguesaT.insertarProducto(carne);
            hamburguesaT.insertarProducto(tocino);
            hamburguesaT.insertarProducto(tomate);
            hamburguesaT.insertarProducto(lechuga);
            hamburguesaT.insertarProducto(queso);

           
            ProductoCompuesto h2x1 = new ProductoCompuesto("COMBO 1");
            h2x1.insertarProducto(simple);
            h2x1.insertarProducto(soda);
            h2x1.insertarProducto(papasfritas);

            ProductoCompuesto c2 = new ProductoCompuesto("COMBO 2");
            c2.insertarProducto(queso);
            c2.insertarProducto(queso);
            c2.insertarProducto(papasfritas);

            ProductoCompuesto SC = new ProductoCompuesto("SUPER COMBO");
            SC.insertarProducto(h2x1);
            SC.insertarProducto(c2);

            OrdenCompra gammerOrden = new OrdenCompra(1, "Juan Perez");
            gammerOrden.insertarProducto(h2x1);
            gammerOrden.imprimirOrden();

            OrdenCompra casaOrden = new OrdenCompra(2, "Marcos Guerra");
            casaOrden.insertarProducto(SC);
            casaOrden.imprimirOrden();

            OrdenCompra comboOrden = new OrdenCompra(3, "Paquete 2x1 en PC");
            comboOrden.insertarProducto(simple);
            comboOrden.imprimirOrden();

            OrdenCompra personalizadoOrden = new OrdenCompra(4, "Oscar Blancarte");
            personalizadoOrden.insertarProducto(simple);
            personalizadoOrden.insertarProducto(soda);
            personalizadoOrden.insertarProducto(soda);
            personalizadoOrden.insertarProducto(SC);
            personalizadoOrden.insertarProducto(papasfritas);
            personalizadoOrden.imprimirOrden();

            Console.ReadKey();

        }
    }
}
