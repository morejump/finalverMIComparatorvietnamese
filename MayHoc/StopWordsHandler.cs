using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayHoc
{
   
    class StopWordsHandler
    {
        public static string relativePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        //get string array of stop words
        public static string[] stopWordsList = System.IO.File.ReadAllLines(relativePath + "\\vnStop-words.txt");

        public static Boolean IsStotpWord(string word)
        {
            if (stopWordsList.Contains(word))
                return true;
            else
                return false;
        }
    }
}
