using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab4
{
    public class ByTypes
    {
        public ByTypes()
        {
            List<string> imagesList = new List<string> { ".png", ".webp", ".jpg", ".gif", ".tiff" };
            List<string> audioList = new List<string> { ".ogg", ".mp3" };
            List<string> videoList = new List<string> { ".mkv", ".mp4", ".webm" };
            List<string> documentList = new List<string> { ".txt", ".doc", ".docx", ".xml", ".xlmx" };

            IDictionary<string, List<string>> extensionsTypes = new Dictionary<string, List<string>>();

            extensionsTypes.Add("images", imagesList);
            extensionsTypes.Add("audio", audioList);
            extensionsTypes.Add("video", videoList);
            extensionsTypes.Add("documents", documentList);

            List<string> imageFiles = Directory.GetFiles("/Users/kacperkita/Documents/Studia", "*.*", SearchOption.TopDirectoryOnly)
            .Where(file => extensionsTypes["images"]
            .Contains(Path.GetExtension(file)))
            .ToList();

            List<string> audioFiles = Directory.GetFiles("/Users/kacperkita/Documents/Studia", "*.*", SearchOption.TopDirectoryOnly)
            .Where(file => extensionsTypes["audio"]
            .Contains(Path.GetExtension(file)))
            .ToList();

            List<string> videoFiles = Directory.GetFiles("/Users/kacperkita/Documents/Studia", "*.*", SearchOption.TopDirectoryOnly)
            .Where(file => extensionsTypes["video"]
            .Contains(Path.GetExtension(file)))
            .ToList();

            List<string> documentsFiles = Directory.GetFiles("/Users/kacperkita/Documents/Studia", "*.*", SearchOption.TopDirectoryOnly)
            .Where(file => extensionsTypes["documents"]
            .Contains(Path.GetExtension(file)))
            .ToList();

            ShowTypes(imageFiles: imageFiles, audioFiles: audioFiles, videoFiles: videoFiles, documentsFiles: documentsFiles);
        }

        public static void ShowTypes(List<string> imageFiles, List<string> audioFiles, List<string> videoFiles, List<string> documentsFiles)
        {
            Console.WriteLine("Files: ");
            Console.WriteLine("\tBy Types:");
            Console.WriteLine("\t\t\t[count]\t[total size]\t[avg size]\t[min size]\t[max size]");
            Console.WriteLine($"\t  images\t {imageFiles.Count}\t {GetFilesSize(imageFiles)}");
            Console.WriteLine($"\t  audio \t {audioFiles.Count}\t {GetFilesSize(audioFiles)}");
            Console.WriteLine($"\t  video \t {videoFiles.Count}\t {GetFilesSize(videoFiles)}");
            Console.WriteLine($"\t  document\t {documentsFiles.Count}\t {GetFilesSize(documentsFiles)}");
        }

        private static int GetFilesSize(List<string> list)
        {
            int totalSize = 0;

            foreach(var item in list)
            {
                totalSize += item.Length;
            }

            return totalSize;
        }
    }
}
