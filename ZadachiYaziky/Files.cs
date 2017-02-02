using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadachiYaziky
{
    class Files
    {
        
        public void CreateAndWriteText(string file,string text)
        {
            FileInfo files = new FileInfo("D:\\" + file);
            StreamWriter write = files.CreateText();

            if (files.Exists)
            {
                write.WriteLine(text);
                write.Close();
                write.Dispose();
            }
        }

        public void ReplaceAndSave(string source,string syn,string resfile)
        {
            StreamReader read = new StreamReader("D:\\" + source);
            StreamReader read2 = new StreamReader("D:\\" + syn);
            FileInfo files = new FileInfo("D:\\" + resfile);
            StreamWriter write = files.CreateText();
            int len = 0;
            

            string sour = read.ReadLine();
            string synon = read2.ReadLine();
            string newline = sour;
            string[] synarr = synon.Split(',');

            if (len < sour.Length)
            {
                for (int j = 0; j < synarr.Count() - 1; j++)
                {
                    if (sour.Contains(synarr[j]) && j % 2 == 0)
                    {
                        sour = sour.Replace(synarr[j], "*" + synarr[j + 1]);
                        len = sour.IndexOf('*');
                        sour = sour.Replace("*", "");
                    }

                }
            }



            Console.WriteLine(sour);
            write.WriteLine(sour);
            write.Close();

        }
    }
}
