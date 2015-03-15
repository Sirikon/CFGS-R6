using System;
using System.Text;

namespace R6E9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validador de Código Cuenta Cliente (CCC)");
            Console.Write("Introduzca el CCC: ");
            String ccc = Console.ReadLine();
            Boolean r = ValidarCC(ccc);
            if (r)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El CCC introducido es válido");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El ccc introducido es inválido");
            }
            Console.ResetColor();
            Console.WriteLine("Pulse enter para salir...");
            Console.ReadLine();
        }

        /// <summary>
        /// Elimina todos los caracteres inválidos de un CCC
        /// </summary>
        /// <param name="ccc">CCC para limpiar</param>
        /// <returns>CCC limpio</returns>
        static String LimpiarCCC(String ccc)
        {
            StringBuilder sb = new StringBuilder();
            Int32 Zero = (Int32)'0';
            Int32 Nine = (Int32)'9';
            for (int i = 0; i < ccc.Length; i++)
            {
                if ((Int32)ccc[i] >= Zero && (Int32)ccc[i] <= Nine)
                    sb.Append(ccc[i]);
            }
            return sb.ToString();
        }

        static Int32[] VALIDATION_MATRIX = new Int32[20] {4,8,5,10,9,7,3,6,0,0,1,2,4,8,5,10,9,7,3,6};

        /// <summary>
        /// Valida un Código de Cuenta de Cliente
        /// </summary>
        /// <param name="ccc">Código de Cuenta de Cliente</param>
        /// <returns>Válido</returns>
        static Boolean ValidarCC(String ccc)
        {
            String c = LimpiarCCC(ccc);
            if (c.Length != 20)
                return false;

            Int32 bankEntityCount = 0;
            for (int i = 0; i < 8; i++)
                bankEntityCount += Int32.Parse(c[i].ToString()) * VALIDATION_MATRIX[i];

            Int32 accountCount = 0;
            for (int i = 10; i < 20; i++)
                accountCount += Int32.Parse(c[i].ToString()) * VALIDATION_MATRIX[i];

            Int32 bankEntityMod = 11 - (bankEntityCount % 11);
            if (bankEntityMod == 10)
                bankEntityMod = 1;
            if (bankEntityMod == 11)
                bankEntityMod = 0;

            Int32 accountMod = 11 - (accountCount % 11);
            if (accountMod == 10)
                accountMod = 1;
            if (accountMod == 11)
                accountMod = 0;

            if (Int32.Parse(c[8].ToString()) != bankEntityMod)
                return false;

            if (Int32.Parse(c[9].ToString()) != accountMod)
                return false;

            return true;
        }
    }
}
