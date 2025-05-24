using System;

namespace Ejemplo1_Promedio
{
    internal class Program
    {
        #region variables y  métodos del dominio del problema
        static double acum;
        static int contador;


        static double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = acum / contador;
            return promedio;
        }


        static void RegistrarNota(double nota)
        {
            acum += nota;
            contador++;
        }
        #endregion


        #region métodos para la vista
        /*
         relacionados con las impresiones en pantalla y capturas
         de datos de la entrada del usuario
        */


        /*
         * */

        static int MostrarPantallaMenuYSolicitarOpcion()
        {
            Console.Clear();


            Console.WriteLine(" \t\t Cálculo de promedio de notas\n\n");


            Console.WriteLine("\t1-  Ingrese la nota de un alumno");
            Console.WriteLine("\t2-  Mostrar promedio de las notas cargadas");
            Console.WriteLine("\tOtro-  Cerrar");


            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        /*
        */
        static void MostrarPantallaSolicitudNota()
        {
            Console.Clear();
            Console.WriteLine(" \t\t Solicitud de ingreso de nueva nota\n\n");


            Console.WriteLine(" Ingrese a continuación la nota");
            double nota = Convert.ToDouble(Console.ReadLine());


            RegistrarNota(nota);


            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }




        /**/


        static void MostrarPantallaConsultaPromedio()
        {
            Console.Clear();
            Console.WriteLine(" \t\t Consulta del promedio general\n\n");


            double promedio = CalcularPromedio();
            Console.WriteLine(" El promedio resultante es: {0:f2}", promedio);

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }


        #endregion
        static void Main(string[] args)
        {
            int op = MostrarPantallaMenuYSolicitarOpcion();


            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        {
                            MostrarPantallaSolicitudNota();
                        }
                        break;
                    case 2:
                        {
                            MostrarPantallaConsultaPromedio();
                        }
                        break;
                    default:
                        {
                            op = -1;
                        }
                        break;
                }


                if (op != -1)
                {
                    op = MostrarPantallaMenuYSolicitarOpcion();
                }
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }

    }
}
