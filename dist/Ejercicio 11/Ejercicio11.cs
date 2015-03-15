using System;
using System.Text;

namespace R6E11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto y lo pasaré a mayúsculas");
            Console.Write("Texto: ");
            String text = Console.ReadLine();
            if (text == "")
            {
                Console.WriteLine("No ha escrito nada...");
            }
            else
            {
                Console.WriteLine("Texto en mayúsculas: " + AMayuscula(text));
            }
            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
        }

        static String MATRIX_MINUS = "çñáàäâéèëêíìïîóòöôúùüû";
        static String MATRIX_MAYUS = "ÇÑÁÀÄÂÉÈËÊÍÌÏÎÓÒÖÔÚÙÜÛ";

        /// <summary>
        /// Pasa a mayúsculas la cadena de texto dada
        /// 
        /// Acepta todos los caracteres ingleses, la Ñ, la Ç y las vocales con tildes (áà) diéresis (ä) y sombrerito (â)
        /// </summary>
        /// <param name="t">Cadena para pasar a mayúsculas</param>
        /// <returns>Cadena en mayúsculas</returns>
        static String AMayuscula(String t)
        {
            Int32 AMin = (Int32)'a';
            Int32 ZMin = (Int32)'z';
            Int32 AMay = (Int32)'A';
            Int32 toMayusDiff = AMay - AMin;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < t.Length; i++)
            {

                if ((Int32)t[i] >= AMin && (Int32)t[i] <= ZMin)
                {
                    sb.Append((char)((Int32)t[i]+toMayusDiff));
                }
                else if( MATRIX_MINUS.IndexOf(t[i]) >= 0 )
                {
                    sb.Append(MATRIX_MAYUS[MATRIX_MINUS.IndexOf(t[i])]);
                }
                else
                {
                    sb.Append(t[i]);
                }
            }

            return sb.ToString();
        }
    }
}
