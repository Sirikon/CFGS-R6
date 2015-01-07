using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R6E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(contarPalabras(Console.ReadLine(), Console.ReadLine()[0]));
        }

        static Int32 contarPalabras(String t, Char s)
        {
            Int32 c = 1;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == s && i != 0 && i != t.Length - 1) {
                    if(t[i-1] != s)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}