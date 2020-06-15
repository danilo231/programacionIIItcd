using System;

namespace pilacliente
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;



         

            do
            {
                Console.WriteLine("1. Iniciar");
                Console.WriteLine("1. Ingresar");
                Console.WriteLine("2. Salida");
                Console.WriteLine("3. mostrar");

                Console.WriteLine("7. Salir");


                opcion = int.Parse(Console.ReadLine());

               
                string c ;


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca operacion");
                        String operacion = Console.ReadLine();
                        Console.WriteLine("Introduzca Nombre");
                        String nombre = Console.ReadLine();



                        Console.WriteLine("Introduzca Apellido");
                        String apellido = Console.ReadLine();





                        //Console.WriteLine("introduzca sexo ");
                        //String sexo = Console.ReadLine();
                        //Sexo sexo1;
                        //Enum.TryParse(sexo, out sexo1);

                        Console.WriteLine("introduzca edad");
                        int edad = int.Parse(Console.ReadLine());

                        c = PilaCliente.getInstancia().lista(operacion,nombre,apellido,edad);
                        Console.ReadKey();
                        break;
                    //case 2:
                    //    Console.WriteLine("introduzca NOmbre");
                    //    String p = Console.ReadLine();
                    //    Console.WriteLine(c.SalirPersona(p));
                    //    Console.ReadKey();
                    //    break;
                    //case 3:
                    //    x.getDatos();
                    //    Console.ReadKey();
                    //    break;


                }

            } while (opcion != 4);

        }
    }
    
}
