using System;
using System.Text;

namespace T6E10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduzca un número y le será devuelto en letra");
            Int32 num;
            try
            {
                num = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                num = -1;
            }
            String res = NtoString(num);
            if (res != null)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Número inválido:");
                Console.ResetColor();
                Console.Write(" Tiene que ser un valor numérico entre 0 y 999.999\n\r");
            }
            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
        }

        static String[] tablaUnidades = new String[] { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE" };
        static String[] tablaDecimalesEspeciales = new String[] { "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE" };
        static String[] tablaPrefijoDecimal = new String[] { "DIEZ", "", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
        static String[] tablaPrefijoCientos = new String[] { "", "DOS", "TRES", "CUATRO", "", "SEIS", "SETE", "OCHO", "NOVE" };

        /// <summary>
        /// Dado un número entre 0 y 999.999 devuelve su nombre escrito
        /// </summary>
        /// <param name="numero">Número a convertir</param>
        /// <returns>Nombre escrito</returns>
        static String NtoString(int numero)
        {
            if (numero < 0 || numero > 999999) return null;
            else if (numero <= 9) return tablaUnidades[numero];
            else if (numero <= 99)
            {
                Int32 deci = numero / 10, resto = numero % 10;
                if (numero <= 15 && numero >= 10) return tablaDecimalesEspeciales[numero - 10];
                else if (deci == 2 && resto == 0) return "VEINTE";
                else
                {
                    if (resto != 0 && deci == 2) return "VEINTI" + NtoString(resto);
                    if (resto != 0) return tablaPrefijoDecimal[deci - 1] + " Y " + NtoString(resto);
                    else return tablaPrefijoDecimal[deci - 1];
                }
            }
            else if (numero <= 999)
            {
                Int32 hundred = numero / 100, resto = numero % 100;
                String toreturn;
                if (numero == 100) toreturn = "CIEN";
                else if (hundred == 1) toreturn = "CIENTO";
                else if (hundred == 5) toreturn = "QUINIENTOS";
                else toreturn = tablaPrefijoCientos[hundred - 1] + "CIENTOS";
                if (resto != 0) toreturn += " " + NtoString(resto);
                return toreturn;
            }
            else if (numero <= 999999)
            {
                String firstpart = "", toreturn = "";
                Int32 resto = numero % 1000, resultado = numero / 1000;
                firstpart = NtoString(resultado);
                if (resultado == 1) toreturn = "MIL";
                if (firstpart.Substring(firstpart.Length - 3) == "UNO") firstpart = firstpart.Substring(0, firstpart.Length - 1);
                if (resultado != 1) toreturn = firstpart + " MIL";
                if (resto != 0) return toreturn + " " + NtoString(resto);
                else return toreturn;
            }
            return null;
        }
    }
}
