using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class Orders
    {
        public List<string> headers;
        public List<FileDetails> values;
        System.Text.StringBuilder log = new System.Text.StringBuilder();
        Utils utils = new Utils();

        public Orders(List<string> headers, List<FileDetails> values)
        {
            this.headers = headers;
            this.values = values;
        }

        public override string ToString()
        {
            return log.ToString();
        }

        public void Print(List<string> headers, List<FileDetails> values, bool path, string head)
        {
            log.Append(String.Format($"\t{head}"));
            Utils.CreateHeaders(headers, log);
            foreach (var item in values)
            {

                log.Append(String.Format("{0,20} {1, 15}\t\t", item.Name, item.Size));
                if (path)
                {
                    log.Append(String.Format("{0, 12}", $"{item.Path}\n"));
                }
                else
                    log.Append("\n");
            }
            log.Append(String.Format($"\n"));
        }
    }
}
