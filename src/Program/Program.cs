using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] ProgMainBoard = FileRead.GenerateBoard();
            Printer.consolePrinter(ProgMainBoard);
        }
    }
}
