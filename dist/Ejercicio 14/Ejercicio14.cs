using System;
using System.Text;

namespace R6E14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime una palabra y te diré si es o no palíndroma");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Palabra: ");
            Console.ResetColor();
            Boolean r = EsPalindromo(Console.ReadLine());
            if (r)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Es palíndroma");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO es palíndroma");
            }
            Console.ResetColor();
            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
        }

        static Boolean EsPalindromo(String s)
        {
            s = s.ToLower();
            for (int i = 0; i < s.Length - 1 - i; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
