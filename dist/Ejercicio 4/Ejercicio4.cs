using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R6E4
{
    class Program
    {
        static void Main(String[] args)
        {
            String t = "";
            Console.WriteLine("Dime un texto y quitaré los espacios sobrantes a ambos lados");
            try
            {
                t = Console.ReadLine();
            }
            catch
            {
                // Gotta Catch 'Em All!!!!
                Console.WriteLine("Hubo un error inesperado...");
            }
            Console.WriteLine("'" + trimAll(t) + "'");
            Console.ReadLine();
        }

        /// <summary>
        /// Ejecuta las trimD y trimI sobre el String dado
        /// </summary>
        /// <param name="t">String al cual borrar los espacios sobrantes en los extremos</param>
        /// <returns>Cadena limpia</returns>
        static string trimAll(String t)
        {
            return trimD(trimI(t));
        }

        /// <summary>
        /// Elimina los espacios sobrantes a la Izquierda
        /// </summary>
        /// <param name="t">Cadena sobre la que actuar</param>
        /// <returns>Cadena limpia</returns>
        static string trimI(String t)
        {
            StringBuilder sb = new StringBuilder(t);
            int cp = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != ' ')
                {
                    cp = i;
                    break;
                }
            }
            sb.Remove(0, cp);
            return sb.ToString();
        }

        /// <summary>
        /// Elimina los espacios sobrantes a la Derecha
        /// </summary>
        /// <param name="t">Cadena sobre la que actuar</param>
        /// <returns>Cadena limpia</returns>
        static string trimD(String t)
        {
            StringBuilder sb = new StringBuilder(t);
            int cp = 0;
            for (int i = t.Length - 1; i >= 0; i--)
            {
                if (t[i] != ' ')
                {
                    cp = i + 1;
                    break;
                }
            }
            sb.Remove(cp, t.Length - cp);
            return sb.ToString();
        }
    }
}