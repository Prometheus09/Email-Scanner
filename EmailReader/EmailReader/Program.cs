using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Collections.Specialized;


namespace EmailReader
{
    class Program
    {
       
        static void Main(string[] args)
        {
            KeywordFinders keywordFinder = new KeywordFinders();
            ExtensionFactory factory = new ConcreteExtensionFactory();

            keywordFinder.FindAllKeywordsAndAddToSpecificList();

            if (keywordFinder.logsForLunchFull == true)
            {
                IFileExtension textFile = factory.GetExtension(".xml");
                string logFilesForLunch = string.Join("", keywordFinder.logsForLunch.ToArray());
                textFile.Write(logFilesForLunch);
            }

            if (keywordFinder.logsForPromotionFull == true)
            {
                IFileExtension textFile2 = factory.GetExtension(".txt");
                string logFilesForPromotion = string.Join("", keywordFinder.logsForPromotion.ToArray());
                textFile2.Write(logFilesForPromotion);
            }

            if (keywordFinder.logsForNewProjectFull == true)
            {
                IFileExtension textFile3 = factory.GetExtension(".csv");
                string logFilesForNewProject = string.Join("", keywordFinder.logsForNewProject.ToArray());
                textFile3.Write(logFilesForNewProject);
            }
          

        }
    }
}
               
