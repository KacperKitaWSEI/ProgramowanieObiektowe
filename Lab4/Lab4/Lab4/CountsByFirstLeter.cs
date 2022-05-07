using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class CountsByFirstLetter
    {
        public List<FileDetails> values;
        System.Text.StringBuilder log = new System.Text.StringBuilder();

        public CountsByFirstLetter(List<FileDetails> values)
        {
            this.values = values;
        }

        public override string ToString()
        {
            return log.ToString();
        }

        public void Print(string head)
        {
            log.Append(String.Format($"\t{head}"));
            log.Append(String.Format("{0,12}", ""));

            SortedDictionary<Char, int> letters = new SortedDictionary<Char, int>();
            foreach (var c in values.Select(x => Char.ToLower(x.FirstLetter)).ToList())
            {
                if (!letters.ContainsKey(c))
                {
                    letters.Add(c, 0);
                }

                letters[c]++;
            }

            foreach (var c in letters.Keys)
            {
                if (Char.IsLetter(c))
                {
                    log.Append(String.Format("{0,5}", $"{c}"));
                }
            }
            log.Append(String.Format("\n"));
            log.Append(String.Format("{0,12}", ""));
            foreach (var c in letters.Keys)
            {
                if (Char.IsLetter(c))
                {
                    log.Append(String.Format("{0,5}", $"{letters[c]}"));
                }
            }
            log.Append(String.Format($"\n\n"));
        }
    }
}
