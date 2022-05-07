using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class RecursiveFileProcessor
    {
        private static int dirsCount = 0;
        private static int filesCount = 0;
        private static long filesSize = 0;


        public static Dictionary<string, string> extensions_values = new Dictionary<string, string> {
            {".png", "image" },
            {".webp", "image"},
            {".jpg", "image"},
            {".gif", "image" },
            {".tiff", "image" },
            {".ogg", "audio" },
            {".mp3", "audio" },
            {".mkv", "video" },
            {".mp4", "video" },
            {".webm", "video" },
            {".txt", "document" },
            {".doc", "document" },
            {".docx", "document"},
            {".xml", "document" },
            {".xlmx", "document" },
            {"other", "other" }

        };

        internal void Print()
        {
            throw new NotImplementedException();
        }

        public static List<FileDetails> files = new List<FileDetails>();


        public void Run(string path)
        {


            if (File.Exists(path))
            {
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }

        }

        public static void ProcessDirectory(string targetDirectory)
        {
            dirsCount += 1;

            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                ProcessFile(fileName);
            }

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory);
            }

        }

        public static void ProcessFile(string path)
        {

            FileInfo fi = new FileInfo(path);

            filesCount += 1;
            filesSize += fi.Length;

            var category = extensions_values.ContainsKey(fi.Extension) ? extensions_values[fi.Extension] : "other";
            var extension = extensions_values.ContainsKey(fi.Extension) ? fi.Extension : "other";

            FileDetails fileDetail = new FileDetails(fi.Name, extension, category, fi.FullName, fi.Length);
            files.Add(fileDetail);


        }

        public void Log()
        {

            Console.WriteLine("Nodes:");
            Nodes nodes = new Nodes(dirsCount, filesCount, filesSize);
            Console.WriteLine(nodes);

            List<string> HEADER = new List<string> { "count", "total size", "avg size", "min size", "max size" };
            var sizes = new Dictionary<long, long> { { 0, 1024 }, { 1024, 1048576 }, { 1048576, 1073741824 }, { 1073741824, 3073741824 } };

            ByTypes byTypes = new ByTypes(HEADER, files);
            ByExtensions byExtensions = new ByExtensions(HEADER, files);
            BySizes bySizes = new BySizes(HEADER, files);
            CountsByFirstLetter firstLeter = new CountsByFirstLetter(files);
            Orders orders = new Orders(HEADER, files);

            Console.WriteLine("Files: ");

            byTypes.Print(HEADER, files.Select(x => x.Category).Distinct(), "By types:\n");
            byExtensions.Print(HEADER, files.Select(x => x.Extension).Distinct(), "By extensions:\n");
            bySizes.Print(HEADER, sizes, "By sizes:\n");
            firstLeter.Print("Counts by first letter:\n");
            orders.Print(new List<string> { "size", "path" }, files.OrderBy(v => v.Name).ToList(), true, "Ordered by name:\n");
            orders.Print(new List<string> { "size" }, files.OrderByDescending(v => v.Size).ToList(), false, "Ordered by sizes (from biggest):\n");

            Console.WriteLine(byTypes);
            Console.WriteLine(byExtensions);
            Console.WriteLine(bySizes);
            Console.WriteLine(firstLeter);
            Console.WriteLine(orders);
        }


    }
}
