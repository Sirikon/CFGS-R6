using System;
using System.Text;
using System.Text.RegularExpressions;

namespace R6E12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Separador de palabras\nIntroduce una frase y te separo las palabras usando espacios, guiones y OR lógicos (' ' - |)");
            Console.Write("Frase: ");
            String[] lista = listaPalabras(Console.ReadLine());
            Console.WriteLine("  LISTA DE PALABRAS INTRODUCIDAS");
            Console.WriteLine("==================================");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("==================================");
            Console.WriteLine("\nPulse enter para salir...");
            Console.ReadLine();
        }

        static String[] listaPalabras(String cadena)
        {
            String[] cut;
            cut = Regex.Split(cadena, "[ |-]");
            String[] result = new String[cut.Length];
            Int32 rc = 0;
            for (int i = 0; i < cut.Length; i++)
            {
                if (cut[i] != "")
                {
                    result[rc] = cut[i].Substring(0, 1).ToUpper() + cut[i].Substring(1, cut[i].Length - 1);
                    rc++;
                }
            }
            Array.Resize(ref result, rc);
            return result;
        }
    }
}
