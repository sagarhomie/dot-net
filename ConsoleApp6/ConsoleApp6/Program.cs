using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public partial class Geeks
    {
        private string Author_name;
        private int Total_articles;

        public Geeks(string a, int t)
        {
            this.Author_name = a;
            this.Total_articles = t;
        }
        public static void Main(string[] args)
        {
            Geeks name = new Geeks("sagar",10);
            name.Display();
        }
    }

}
