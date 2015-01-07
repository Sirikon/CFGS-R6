using System;

namespace R6E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula la letra de tu NIF");
            Console.Write("DNI: ");
            String dni = Console.ReadLine();
            try
            {
                Console.WriteLine("La letra del NIF es '" + letraNIF(dni) + "'");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DNI inválido");
                Console.ResetColor();
            }
            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
        }

        const String NIF_CONTROL_MATRIX = "TRWAGMYFPDXBNJZSQVHLCKE";
        static Char letraNIF(String dni)
        {
            Int32 nnif = Int32.Parse(dni);
            return NIF_CONTROL_MATRIX[nnif % 23];
        }
    }
}