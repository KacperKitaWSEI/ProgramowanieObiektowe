using System;
using System.IO;
using System.Linq;

namespace Lab4
{
    public class Nodes
    {
        public Nodes()
        {
            ShowSize("/Users/kacperkita/Documents/Studia");
        }

        public static void ShowSize(string path)
        {
            Console.Write("Files:");
            Console.WriteLine(Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length);
            Console.Write("Directores:");
            Console.WriteLine(Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).Length);

            DirectoryInfo dirInfo = new DirectoryInfo(path);


            Console.WriteLine($"File size: {Math.Round(ConvertBytesToMegabytes(FileSize(dirInfo)), 2)}MB");
            Console.WriteLine($"Dir size: {Math.Round(ConvertBytesToMegabytes(DirSize(dirInfo)), 2)}MB");


            Console.WriteLine("Nodes:");
            Console.WriteLine("\t\t\t[count]\t[total size]");
            Console.WriteLine($"\tDirectories: \t {Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).Length} \t {Math.Round(ConvertBytesToMegabytes(DirSize(dirInfo)), 2)}MB");
            Console.WriteLine($"\tFiles: \t\t {Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length} \t {Math.Round(ConvertBytesToMegabytes(FileSize(dirInfo)), 2)}MB");
            Console.WriteLine();
        }

        public static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        public static long FileSize(DirectoryInfo dInfo)
        {
            // Enumerate all the files
            long filesize = dInfo.EnumerateFiles()
                         .Sum(file => file.Length);

            return filesize;
        }

        public static long DirSize(DirectoryInfo dInfo)
        {
            long dirSize = dInfo.EnumerateDirectories()
                         .Sum(dir => FileSize(dir));

            return dirSize;
        }
    }
}