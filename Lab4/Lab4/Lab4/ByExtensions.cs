using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class ByExtensions
    {
        public List<string> headers;
        public List<FileDetails> values;
        System.Text.StringBuilder log = new System.Text.StringBuilder();
        Utils utils = new Utils();

        public ByExtensions(List<string> headers, List<FileDetails> values)
        {
            this.headers = headers;
            this.values = values;
        }

        public override string ToString()
        {
            return log.ToString();
        }

        public void Print(List<string> headers, IEnumerable<string> indexes, string head)
        {
            log.Append(String.Format($"\t{head}"));
            Utils.CreateHeaders(headers, log);
            foreach (var idx in indexes)
            {
                var sorted = values.Where(x => x.Extension == idx).ToList();

                var counts = sorted.Count();
                if (counts > 0)
                {
                    Utils.Stats(sorted, counts, idx, log);
                }
                else
                {
                    log.Append(String.Format("{0,20} {1,12}\n\n", $"{idx}", $"{counts}"));
                }
            }
            log.Append(String.Format($"\n"));

        }
    }
}
