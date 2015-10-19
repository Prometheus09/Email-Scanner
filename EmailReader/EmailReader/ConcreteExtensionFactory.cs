using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmailReader
{
    public class ConcreteExtensionFactory : ExtensionFactory
    {
        public override IFileExtension GetExtension(string extension)
        {

            switch (extension)
            {
                case ".txt":
                    return new TxtFile();
                case ".csv":
                    return new CsvFile();
                case ".xml":
                    return new XmlFile();
                default:
                    throw new ApplicationException();
            }
        }
      
    }
}
