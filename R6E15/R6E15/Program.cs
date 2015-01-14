using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R6E15
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu("Gestor de ArrayList", "Selecciona una de las opciones", null);
        }

        static Int32 Menu(String title, String subtitle, String[] options)
        {
            Console.Clear();
            Console.WriteLine("\r\n   " + title);
            Console.WriteLine(" ".PadRight(title.Length + 5,'='));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" " + subtitle + "\r\n");
            Console.ResetColor();

            

            return 0;
        }
    }
}
