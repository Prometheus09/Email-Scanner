using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace EmailReader
{
    public class KeywordFinders
    {
        int counter = 0;
        string line;
      
        
        public List<string> logsForLunch = new List<string>();
        public List<string> logsForPromotion = new List<string>();
        public List<string> logsForNewProject = new List<string>();

   
        public bool logsForLunchFull = false;
        public bool logsForPromotionFull = false;
        public bool logsForNewProjectFull = false;

     

        public void FindAllKeywordsAndAddToSpecificList()
        {
            string[] lines = System.IO.File.ReadAllLines("EmailScanner.cfg");
            string[] linesLunchEmail = System.IO.File.ReadAllLines("Lunch.email");
            string[] linesNewProjectEmail = System.IO.File.ReadAllLines("NewProject.email");
            string[] linesPromotionEmail = System.IO.File.ReadAllLines("Promotion.email");
            List<string> emails2 = lines[0].Split(' ').ToList();
            int emailNumber = 0;
            foreach (string element in emails2)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(element);
                emailNumber++;
                string whichEmail;
                while ((line = file.ReadLine()) != null)
                {
                    switch(emailNumber)
                    {
                        case 1:
                            whichEmail = linesLunchEmail[0] + Environment.NewLine + linesLunchEmail[1] + Environment.NewLine + linesLunchEmail[2] + Environment.NewLine;
                            break;
                        case 2:
                            whichEmail = linesNewProjectEmail[0] + Environment.NewLine + linesNewProjectEmail[1] + Environment.NewLine + linesNewProjectEmail[2] + Environment.NewLine;
                            break;
                        case 3:
                            whichEmail = linesPromotionEmail[0] + Environment.NewLine + linesPromotionEmail[1] + Environment.NewLine + linesPromotionEmail[2] + Environment.NewLine;
                            break;
                        default:
                            throw new ApplicationException();
                    }
                    if (line.Contains("lunch")||line.Contains("free")||line.Contains("food")||line.Contains("lobby"))
                        
                    {
                       
                        logsForLunch.Add(Environment.NewLine + whichEmail + "context: " + line + Environment.NewLine);
                        logsForLunchFull = true;
                       
                    }
                    if (line.Contains("promotion") || line.Contains("promot") || line.Contains("Developer"))
                    {

                        logsForPromotion.Add(Environment.NewLine + whichEmail + "context: " + line + Environment.NewLine);
                        logsForPromotionFull = true;
                        
                    }
                    if (line.Contains("project") || line.Contains("new") || line.Contains("meeting"))
                    {

                        logsForNewProject.Add(Environment.NewLine + whichEmail + "context: " + line + Environment.NewLine);
                        logsForNewProjectFull = true;
                    }
                    
                    counter++;
                    
                }
           
            }

        }


   
    }

}
