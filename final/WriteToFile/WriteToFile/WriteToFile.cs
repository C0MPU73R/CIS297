using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFile
{
    public class WriteToFile
    {
        public WriteToFile(string fileName, string content)
        {
            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\" + fileName,content);

        }

    }
}
