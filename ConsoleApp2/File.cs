using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class File
    {
        public string name { get; set; }

        public DateTime date { get; set; }
        public string type { get; set; }

        public File(string name, string type, DateTime date)
        {
            this.name = name;
            this.type = type;
            this.date = date;
        }
    }
}
