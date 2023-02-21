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

        public static void ading(out List<File> files)
        {
            files = new List<File>();
            string nam = Console.ReadLine();
            string type = Console.ReadLine();
            DateTime date = DateTime.Now;
            if (nam == "лив")
            {
                return;
            }
            files.Add(new File(nam, type, date));
            ading(out files);
        }
    }
}
