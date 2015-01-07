/*
 * Programa: Ejercicio 7
 *  Función: Calcular ISBN
 *    Fecha: 07/01/2015              Versión: 1.0
 *    Autor: Carlos Fernández Llamas
 */

using System;
using System.Text;

namespace T6E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un ISBN para comprobar que es válido");
            String isbn = Console.ReadLine();
            bool res = validarISBN(isbn);
            if (res)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Válido");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inválido");
            }
            Console.ResetColor();
            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
        }

        /// <summary>
        /// Limpia una cadena con un ISBN de caracteres inválidos
        /// </summary>
        /// <param name="isbn">Cadena con un ISBN</param>
        /// <returns>ISBN limpio</returns>
        static string limpiarISBN(string isbn)
        {
            int zero = (int)'0';
            int nine = (int)'9';
            int actu = 0;
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < isbn.Length; i++)
            {
                actu = (int)isbn[i];
                /* Si el caracter actual está entre 0 y 9,
                 * o bien ha encontrado la letra X siendo ésta la última
                 * se añade el caracter al resultado
                 */
                if ((actu <= nine && actu >= zero) || ((actu == (int)'x' || actu == (int)'X') && i == isbn.Length - 1))
                {
                    res.Append((char)actu);
                }
            }
            return res.ToString(); ;
        }

        /// <summary>
        /// Comprueba la validez de un ISBN
        /// </summary>
        /// <param name="isbn">ISBN a validar</param>
        /// <returns>Válido</returns>
        static bool validarISBN(string isbn)
        {
            int count = 0;
            String tempISBN = limpiarISBN(isbn);
            if (!(tempISBN.Length == 13 || tempISBN.Length == 10))
            {
                Console.WriteLine("El largo del ISBN tiene que ser de 13 o de 10.");
                return false;
            }
            String control = tempISBN.Substring(tempISBN.Length - 1, 1);
            tempISBN = tempISBN.Substring(0, tempISBN.Length - 1);

            for (int i = 0; i < tempISBN.Length; i++)
            {
                count += (int.Parse(tempISBN[i].ToString()) * (i + 1));
            }

            String controlGet;
            int controlGetInt = count % 11;
            if (controlGetInt == 10)
            {
                controlGet = "X";
            }
            else
            {
                controlGet = controlGetInt.ToString();
            }

            if (controlGet == control.ToString().ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}