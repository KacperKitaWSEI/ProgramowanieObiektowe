using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class BySizes
    {
        public List<string> headers;
        public List<FileDetails> values;
        System.Text.StringBuilder log = new System.Text.StringBuilder();
        Utils utils = new Utils();

        public BySizes(List<string> headers, List<FileDetails> values)
        {
            this.headers = headers;
            this.values = values;
        }
        public override string ToString()
        {
            return log.ToString();
        }

        public void Print(List<string> headers, Dictionary<long, long> indexes, string head)
        {
            log.Append(String.Format($"\t{head}"));
            Utils.CreateHeaders(headers, log);
            foreach (KeyValuePair<long, long> entry in indexes)
            {
                var sorted = values.Where(x => x.Size >= entry.Key && x.Size < entry.Value).ToList();
                var counts = sorted.Count();
                var idx = $"{Utils.GetFileSize(entry.Key)} . {Utils.GetFileSize(entry.Value)}";
                if (counts > 0)
                {
                    Utils.Stats(sorted, counts, idx, log);
                }
                else
                {
                    log.Append(String.Format("{0,20} {1,12} {2,15} {3,15} {4,15} {5,15}\n", $"{idx}", $"{counts}", $"0B", $"0B", $"0B", $"0B"));
                }
            }
            log.Append(String.Format($"\n"));
        }
    }
}
