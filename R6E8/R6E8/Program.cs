/*
 * Programa: Ejercicio 8
 *  Función: Calcular EAN
 *    Fecha: 7/1/2015              Versión: 1.0
 *    Autor: Carlos Fernández Llamas
 */

using System;
using System.Collections.Generic;

namespace T6E8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el EAN para validar");
            bool res = validarEAN(Console.ReadLine());
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
        /// Comprueba que el formato del EAN es correcto
        /// </summary>
        /// <param name="ean">EAN a comprobar</param>
        /// <returns>Correcto</returns>
        static bool validEANFormat(string ean)
        {
            if (!(ean.Length == 8 || ean.Length == 13))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida el EAN
        /// </summary>
        /// <param name="ean">EAN a validar</param>
        /// <returns>Válido</returns>
        static bool validarEAN(string ean)
        {
            if (!validEANFormat(ean))
            {
                return false;
            }

            String digits = ean.Substring(0, ean.Length - 1);
            String control = ean.Substring(ean.Length - 1, 1);
            int sumapares = 0;
            int sumaimpares = 0;
            int actualDigit;
            int result;

            for (int i = 0; i < digits.Length; i++)
            {
                actualDigit = int.Parse(digits[i].ToString());
                if (actualDigit % 2 == 0)
                {
                    sumapares += actualDigit;
                }
                else
                {
                    sumaimpares += actualDigit;
                }
            }

            if (ean.Length == 8)
            {
                result = (sumaimpares * 3) + sumapares;
            }
            else
            {
                result = (sumapares * 3) + sumaimpares;
            }

            int m10 = result % 10;

            if (m10 == 10)
            {
                m10 = 0;
            }

            if (m10 == int.Parse(control))
            {
                return true;
            }
            return false;
        }
    }
}