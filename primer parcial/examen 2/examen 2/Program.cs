using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    class Program
    {
        static void Main(string[] args)
        {
            lista[] listaelect = new lista[13];
            InsertarTodos(listaelect);
            int opcion = 0;
            while (opcion != 13)
            {
                Console.Clear();
                Console.WriteLine("1.- Insertar Mesa");
                Console.WriteLine("2.- Mostrar Lista de mesa Ordenada por eleccion luego por ciudad");
                Console.WriteLine("3.- Mostrar lista de mesas ordenada Mas es Mayor 35");
                Console.WriteLine("4.- Cantidad de voto");
                Console.WriteLine("5.- cantidad de votos diputados");
                Console.WriteLine("6.- mesa donde el mas gano");
               
                Console.WriteLine("13.- Salir");
                Console.Write("Introduzca opcion ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Insertar(listaelect);
                        break;
                    case 2:
                        Mostrar(listaelect);
                        break;
                    case 3:
                        Mayores35Mas(listaelect);
                        break;
                    case 4:
                        AgruparEleccion(listaelect);
                        break;
                    case 5:
                        Cantidadciudad(listaelect);
                        break;
                   
                       


                    default:
                        break;
                }
            }
        }
        static void Insertar(lista[] listaelect)
        {

            Console.Write("Introduzca el nro de alumno: ");
            int nroalumno = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Introduzca el Nombre: ");
            String Nombre = Console.ReadLine();
            Console.Write("Introduzca el Primer Apellido: ");
            String PrimerApellido = Console.ReadLine();
            Console.Write("Introduzca el Segundo Apellido: ");
            int Mas = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el Carnet de Identidad: ");
            int CC = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el Sexo: (M/F) ");
            int Juntos = int.Parse(Console.ReadLine());

            Console.Write("Introduzca la Edad: ");
            int Crecer = int.Parse(Console.ReadLine());


            lista a = new lista(Nombre, PrimerApellido, Mas, CC, Juntos, Crecer);
            listaelect[nroalumno] = a;

        }
        static void InsertarTodos(lista[] listaelect)
        {
            listaelect[0] = new lista("Presidente", "Sucre", 35, 46, 15, 5);
            listaelect[1] = new lista("Diputado", "La Paz", 33, 11, 20, 6);
            listaelect[2] = new lista("Dipitado", "Sucre", 36, 60, 18, 7);
            listaelect[3] = new lista("Presidente", "Sucre", 40, 20, 20, 8);
            
            
        }

        static void Mostrar(lista[] listaelect)
        {
            var todos = from l in listaelect
                        
                        select l;
            foreach (lista a in todos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", a.eleccion, a.Ciudad, a.Mas, a.CC, a.Juntos, a.Crecer);
            }
            Console.ReadKey();

        }
        static void MostrarOrden(lista[] listaalumnos)
        {
            var A = from l in listaalumnos
                          orderby l.eleccion,l.Ciudad
                          
                          select l;
            foreach (lista a in A)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", a.eleccion, a.Ciudad, a.Mas, a.CC, a.Juntos, a.Crecer);
            }
            Console.ReadKey();

        }
       
        public static void Mayores35Mas(lista[] listaalumnos)
        {

            var mayores = from l in listaalumnos
                            where l.Mas > 35
                            select l;
            foreach (lista a in mayores)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", a.eleccion, a.Ciudad, a.Mas, a.CC, a.Juntos, a.Crecer);
            }
            Console.ReadKey();
        }
        
        public static void AgruparEleccion(lista[] listaalumnos)
        {

            var E = from l in listaalumnos
                      
                       group l by l.eleccion into edad
                       select edad;

            foreach (var GrupoEdades in E)
            {
                Console.WriteLine(GrupoEdades.Key);
                foreach (lista alumno in GrupoEdades)
                {
                    Console.WriteLine("{0} {1}", alumno.eleccion, alumno.Ciudad);

                }
            }

            Console.ReadKey();
        }
        public static void Cantidadciudad(lista[] listaalumnos)
        {


            var cantidad = from l in listaalumnos
                           
                           group l by l.Ciudad into Ciudad
                           select new { Eleccion = Ciudad.Key, Cantidad = Ciudad.Count() };

            foreach (var grupoedad in cantidad)
            {
                Console.WriteLine("{0} {1}", grupoedad.Eleccion, grupoedad.Cantidad);

            }
            Console.ReadKey();

        }
       

      
    }
}
