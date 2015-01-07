using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R6E3
{
    class Program
    {
        static void Main(String[] args)
        {
            String t = "";
            Console.WriteLine("Dime un texto y quitaré los espacios sobrantes a la izquierda");
            try
            {
                t = Console.ReadLine();
            }
            catch
            {
                // Gotta Catch 'Em All!!!!
                Console.WriteLine("Hubo un error inesperado...");
            }
            Console.WriteLine("'" + trimI(t) + "'");
            Console.ReadLine();
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
    }
}