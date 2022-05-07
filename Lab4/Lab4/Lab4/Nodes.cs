using System;

namespace Lab4
{
    public class Nodes
    {
        System.Text.StringBuilder log = new System.Text.StringBuilder();
        public Nodes(int dirsCount, int filesCount, long filesSize)
        {
            log.Append(String.Format("{0,38} {1,15}\n", "[count]", "[total size]"));
            log.Append(String.Format("{0,20} {1,12} {2,11}\n", "Directories:", $"{dirsCount}", $"{0}B"));
            log.Append(String.Format("{0,14} {1,18} {2,16}\n", "Files:", $"{filesCount}", $"{Utils.GetFileSize(filesSize)}"));
        }

        public override string ToString()
        {
            return log.ToString();
        }
    }
}
