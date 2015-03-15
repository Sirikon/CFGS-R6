using System;
using System.Text;

namespace R6E13
{
    class Program
    {
        static private Int32 A = (int)'a';
        static private Int32 Z = (int)'z';

        static void Main(string[] args)
        {
            Console.WriteLine("Contador de Letras");
            Console.WriteLine("Introduce un texto y contaré cada letra!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Texto: ");
            Console.ResetColor();

            Int32[] charmap = new Int32[0];
            fillCharmap(ref charmap);
            countChars(Console.ReadLine(), ref charmap);
            Console.WriteLine();
            printCharmap(ref charmap);

            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
        }

        static void fillCharmap(ref Int32[] charmap)
        {
            Array.Resize(ref charmap, Z - A + 1);
            for (int i = 0; i < charmap.Length; i++)
            {
                charmap[i] = 0;
            }
        }

        static void countChars(String s, ref Int32[] charmap)
        {
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                int c = (int)s[i];
                if (c <= Z && c >= A)
                {
                    charmap[c - A]++;
                }
            }
        }

        static void printCharmap(ref Int32[] charmap)
        {
            Int32 initY = Console.CursorTop;
            Int32 initX = Console.CursorLeft;
            for (int i = 0; i < charmap.Length; i++)
            {
                Console.SetCursorPosition(initX + (i * 3) + 2, initY);
                Console.Write((Char)(A + i));
                Console.SetCursorPosition(initX + (i * 3) + 2 - (charmap[i].ToString().Length-1), initY+2);
                Console.Write(charmap[i]);
            }
            Console.SetCursorPosition(initX, initY + 1);
            Console.Write("".PadRight( (charmap.Length*3)+2 ,'='));
            Console.WriteLine("\r\n");
        }
    }
}
