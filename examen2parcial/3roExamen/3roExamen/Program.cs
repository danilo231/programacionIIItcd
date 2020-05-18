using System;

namespace _3roExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoSimple paracetamol = new ProductoSimple("paracetamol", 2);
            ProductoSimple mentisan = new ProductoSimple("mentisan", 4);
            ProductoSimple digestan = new ProductoSimple("digigestan", 3);

            ProductoCompuesto simple = new ProductoCompuesto("Simple",0);
            simple.insertarIngrediente(paracetamol);
            simple.insertarIngrediente(paracetamol);
            simple.insertarIngrediente(digestan);

            ProductoCompuesto tiras = new ProductoCompuesto("Simple",0);
            tiras.insertarIngrediente(paracetamol);
            tiras.insertarIngrediente(digestan);
            tiras.insertarIngrediente(digestan);


            OrdenCompra gammerOrden = new OrdenCompra(1, "Daniel");
            gammerOrden.insertarProducto(tiras);
            gammerOrden.insertarProducto(digestan);
            gammerOrden.imprimirOrden();

            OrdenCompra gammerOrden2 = new OrdenCompra(1, "Lucio");
            gammerOrden2.insertarProducto(simple);
            gammerOrden2.insertarProducto(paracetamol);
            gammerOrden2.imprimirOrden();

            Console.ReadKey();

        }
    }
}
