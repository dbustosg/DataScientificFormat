/**
 * ---------- This software is MIT licensed (see LICENSE) ----------
 * ------------- https://opensource.org/licenses/MIT ---------------
 * ----------------- Developed by: Daniel Bustos -------------------
 * ----------------- https://dbustosg.github.io/ -------------------
 */
using System;

namespace FormatoCientificoFecha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test de los metodos
            String fecha = mapearFechaFormateada(20211001); //Insertamos una fecha en formato cientifico
            Console.WriteLine(fecha);
            Console.WriteLine(mapearFechaFormatoCientifico(fecha)); //La volvemos a convertir a formato cientifico para comprobar su usabilidad
        }

        /**
         * Convierte de formato cientifico a fecha formateada para ser mostrada al usuario
         */
        public static String mapearFechaFormateada(int fecha)
        {
            String fechaString = "";

            String anio = (fecha / 10000).ToString();
            String mes = ((fecha % 10000) / 100).ToString();
            String dia = ((fecha % 10000) % 100).ToString();

            fechaString = dia + "/" + mes + "/" + anio;

            return fechaString;
        }

        /**
         * Convierte una fecha formateada usual que introduzca el usuario
         * a fecha en formato cientifico para poder ser procesada sin problemas de formateo
         */
        public static int mapearFechaFormatoCientifico(String fecha)
        {
            String[] fechaFormateada = fecha.Split('/');

            String anio = fechaFormateada[2];
            String mes  = fechaFormateada[1];
            String dia  = fechaFormateada[0];

            if (dia.Length == 1)
                dia = "0" + dia;

            String fechaFormada = anio + mes + dia;

            return Convert.ToInt32(fechaFormada);
        }
    }
}
