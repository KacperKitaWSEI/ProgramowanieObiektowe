using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Utils
    {
        public static string GetFileSize(double byteCount)
        {
            double GB_SIZE = 1073741824.0;
            double MB_SIZE = 1048576.0;
            double KB_SIZE = 1024.0;
            string size = "0 Bytes";

            if (byteCount >= GB_SIZE)
            {
                size = String.Format("{0:##.##}", byteCount / GB_SIZE) + "GB";
            }
            else if (byteCount >= MB_SIZE)
            {
                size = String.Format("{0:##.##}", byteCount / MB_SIZE) + "MB";
            }
            else if (byteCount >= KB_SIZE)
            {
                size = String.Format("{0:##.##}", byteCount / KB_SIZE) + "KB";
            }
            else if (byteCount > 0 && byteCount < KB_SIZE)
            {
                size = byteCount.ToString() + "B";
            }
            return size;
        }

        public static void CreateHeaders(List<string> headers, StringBuilder log)
        {
            int i = 0;
            foreach (var header in headers)
            {
                if (i == 0)
                    log.Append(String.Format("{0, 38}", $"[{header}]"));
                else
                    log.Append(String.Format("{0, 15}", $"[{header}]"));
                i++;
            }
            log.Append(String.Format("\n"));
        }

        public static void Stats(List<FileDetails> sorted, int counts, string idx, StringBuilder log)
        {
            var size = sorted.Select(x => x.Size).Sum();
            var value_avg_size = (counts != 0) ? Utils.GetFileSize(size / counts) : "0B";
            var value_min = Utils.GetFileSize(sorted.Select(x => x.Size).Min());
            var value_max = Utils.GetFileSize(sorted.Select(x => x.Size).Max());
            log.Append(String.Format("{0,20} {1,12} {2,15} {3,15} {4,15} {5,15}\n", $"{idx}", $"{counts}", $"{Utils.GetFileSize(size)}", $"{value_avg_size}", $"{value_min}", $"{value_max}"));
        }
    }
}
