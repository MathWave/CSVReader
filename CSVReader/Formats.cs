using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    static class Formats
    {

        public static string[] Parse(string line)
        {
            List<string> list = new List<string>();
            string tmp = "";
            int i = 0;
            while (i < line.Length)
            {
                if (i == line.Length - 1 || (line[i] == '"' && line[i + 1] == ';'))
                {
                    i += 3;
                    list.Add(tmp);
                    tmp = "";
                }
                else if (line[i] == ';' && line[i + 1] == '"')
                {
                    i += 2;
                    list.Add(tmp);
                    tmp = "";
                }
                else if (line[i] == '"' && line[i + 1] == '"')
                {
                    tmp += '"';
                    i += 2;
                }
                else
                    tmp += line[i++];
            }
            list.Add(tmp);
            return list.ToArray<string>();
        }

    }
}
