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
            Console.WriteLine(AMayuscula(Console.ReadLine()));
            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
        }

        /// <summary>
        /// Pasa a mayúsculas la cadena de texto data
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
                else if(t[i] == 'ñ')
                {
                    sb.Append('Ñ');
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
