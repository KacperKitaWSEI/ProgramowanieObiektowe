using System;
using System.IO;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ścieżkę bezwględną do folderu: ");

            string rootDir = Console.ReadLine();

            RecursiveFileProcessor processor = new RecursiveFileProcessor();
            processor.Run(rootDir);
            processor.Log();
        }


    }
}
