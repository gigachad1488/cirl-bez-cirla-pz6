using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            List<File> files = new List<File>();
            files.Add(new File("фай", ".exe", DateTime.Now));
            files.Add(new File("adй", ".png", DateTime.Now));
            List<string> fil = files.Where(s => s.type == ".exe").Select(s => s.name).ToList();
            vivod(fil:fil.ToArray());
            Console.ReadKey();
        }

        public static void vivod(int s = 0, params string[] fil)
        {
            if (s < fil.Length)
            {
                Console.WriteLine(fil[s]);
                s++;
                vivod(s, fil);
            }
        }
    }
}
