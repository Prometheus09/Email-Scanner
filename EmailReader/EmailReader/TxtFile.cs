using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailReader
{
    public class TxtFile : IFileExtension
    {
        public void Write(string logs)
        {
     
            System.IO.File.AppendAllText("logFile.txt", logs + Environment.NewLine);
        }
    }
}
