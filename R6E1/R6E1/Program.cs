using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R6E1
{
    class Program
    {
        static void Main(String[] args)
        {
            String t = "";
            Console.WriteLine("Introduce un texto y te lo devolveré al revés");
            try
            {
                t = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Hubo un error inesperado, pruebe con otro texto");
            }
            if (t.Length == 0)
            {
                Console.WriteLine("No escribiste nada...");
            }
            Console.WriteLine(alReves(t));
            Console.ReadLine();
        }

        static String alReves(String t)
        {
            StringBuilder sb = new StringBuilder(t.Length);
            for (int i = t.Length - 1; i >= 0; i--)
            {
                sb.Append(t[i]);
            }
            return sb.ToString();
        }
    }
}
