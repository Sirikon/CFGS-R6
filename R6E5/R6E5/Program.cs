using System;
using System.Collections.Generic;
using System.Text;

namespace R6E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa contará las palabras de una frase");
            Console.Write("Frase: ");
            String phrase = Console.ReadLine();
            Console.Write("Separador: ");
            String separator = Console.ReadLine();

            if (phrase == "")
            {
                Console.WriteLine("No has introducido ninguna frase"); Salir(); return;
            }

            if (separator.Length == 0)
            {
                Console.WriteLine("No has introducido ningún separador"); Salir(); return;
            }

            Int32 cPalabras = contarPalabras(removeRepeatChar(phrase,separator[0]), separator[0]);
            String palabras = "palabras";
            if (cPalabras == 1)
                palabras = "palabra";

            Console.WriteLine("La frase tiene " + cPalabras + " " + palabras);
            Salir();
        }

        static void Salir()
        {
            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
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

        static String removeRepeatChar(String t, Char c)
        {
            StringBuilder r = new StringBuilder();
            Char lastChar = new Char();
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != lastChar)
                {
                    r.Append(t[i]);
                }
                lastChar = t[i];
            }
            return r.ToString();
        }
    }
}