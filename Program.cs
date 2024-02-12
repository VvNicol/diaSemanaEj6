
using System;

namespace diaSemanaEj6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese el nombre del dia de la semana (lunes, martes ...etc ): ");
            string diaSemana = Console.ReadLine().ToLower(); // leer lo typeado y quitar los espacios
            calcularDiaSemana(diaSemana);

        }

        //metodo para obtener las fechas del dia de la semana
        private static void obtenerFechaDia(DayOfWeek diaSemana)
        {
            //primer dia del mes                                          
            DateTime fechaActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); ; 

            // Itera hasta encontrar el primer día de la semana especificado 
            while (fechaActual.DayOfWeek != diaSemana)
            {
                fechaActual = fechaActual.AddDays(1);  // se agrega a la fecha actual 1 dia
            }

            Console.WriteLine("Fechas de este mes:");

            // Itera por cada semana del mes actual
            while (fechaActual.Month == DateTime.Today.Month)
            {
                Console.WriteLine(fechaActual.ToString("dd/MM/yyyy"));
                // Avanzar a la siguiente semana agregando 7 días a la fecha actual
                fechaActual = fechaActual.AddDays(7);
            }
        }

        //Metodo para convertir el dia ingresado a dia de la semana
        private static void calcularDiaSemana(string diaSemana)
        {
            switch (diaSemana)
            {
                case "lunes":

                    obtenerFechaDia(DayOfWeek.Monday);
                    break;
                case "martes":
                    obtenerFechaDia(DayOfWeek.Tuesday);
                   
                    break;
                case "miercoles":
                    obtenerFechaDia(DayOfWeek.Wednesday);
                   
                    break;
                case "jueves":
                    obtenerFechaDia(DayOfWeek.Thursday);
                   
                    break;
                case "viernes":
                    obtenerFechaDia(DayOfWeek.Friday);
                 
                    break;
                case "sabado":
                    obtenerFechaDia(DayOfWeek.Saturday);
                    diaSemana = "Saturday";
                    break;
                case "domingo":
                    obtenerFechaDia(DayOfWeek.Sunday);
    
                    break;
                default:
                    Console.WriteLine("El nombre del día de la semana ingresado no es existe.");
                    return;
            }
        }
    }
}
