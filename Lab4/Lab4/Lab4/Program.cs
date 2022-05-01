using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ShowSize("/Users/kacperkita/Documents/Studia");
        }

        //private static void TreeScan(string sDir)
        //{
        //    foreach (string f in Directory.GetFiles(sDir))
        //    {
        //        Console.Write($"Dir: {f}");
        //    }
        //    foreach (string d in Directory.GetDirectories(sDir))
        //    {
        //        TreeScan(d);
        //    }
        //}

        static void ShowSize(string path)
        {
            Console.Write("Files:");
            Console.WriteLine(Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length);
            Console.Write("Directores:");
            Console.WriteLine(Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).Length);

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            Console.WriteLine($"File size: {Math.Round(ConvertBytesToMegabytes(FileSize(dirInfo)), 2)}MB");
            Console.WriteLine($"Dir size: {Math.Round(ConvertBytesToMegabytes(DirSize(dirInfo)), 2)}MB");
        }

        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        static long FileSize(DirectoryInfo dInfo)
        {
            // Enumerate all the files
            long filesize = dInfo.EnumerateFiles()
                         .Sum(file => file.Length);

            return filesize;
        }

        static long DirSize(DirectoryInfo dInfo)
        {
            long dirSize = dInfo.EnumerateDirectories()
                         .Sum(dir => FileSize(dir));

            return dirSize;
        }
    }
}
