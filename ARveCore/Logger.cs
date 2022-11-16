using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARveCore
{
    partial class Trainer
    {
        public static void Logger(string message, string type, ConsoleColor typeColor, ConsoleColor textColor)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"[{DateTime.Now}] ");
            Console.ForegroundColor = typeColor;
            Console.Write($"[{type}] ");
            Console.ForegroundColor = textColor;
            Console.Write(message + "\n");
            Console.ResetColor();
        }
    }
}
