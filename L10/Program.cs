using System;
using System.Text.RegularExpressions;
namespace RegexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            foreach (Match match in Regex.Matches("Hallo Dal ist ein Textall Heimdall", "al"))
            {
                i++;
                 

            }
            Console.WriteLine("Treffer  "+ i);
            /*string replacedText = Regex.Replace("Dies ist irgendein Beispieltext. Allerdings diesmal ein anderer ","ies", "ette");
            Console.WriteLine(replacedText);*/
        }
    }
}
