using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FilesAndDataStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\C# 2015\Files\";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);





            string path = @"C:\C# 2015\Files\Products.txt";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);








        }
    }
}
