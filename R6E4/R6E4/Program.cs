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

        static string trimAll(String t)
        {
            return trimD(trimI(t));
        }

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