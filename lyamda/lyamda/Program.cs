using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();

            list = getList();
            list1 = Equals("ram", list);
            list2 = startWith("r", list);
            list3 = Contain("krishna", list);
            Console.WriteLine("*****string which is equals to ram*****");
            foreach (string subname in list1)
            {
                Console.WriteLine(subname);
            }
            Console.WriteLine("*****string which is start with to r*****");
            foreach (string subname in list2)
            {

                Console.WriteLine(subname);
            }
            Console.WriteLine("*****string which  contain to krishna*****");
            foreach (string subname in list3)
            {
                Console.WriteLine(subname);
            }
            Console.ReadKey();
        }

        public static List<string> getList()
        {
            List<string> list = new List<string>();
            list.Add("ram");
            list.Add("ram krishna");
            list.Add("Ram");
            list.Add("RAM");
            list.Add("Ram bahadhur");
            list.Add("ram Bahadur");
            list.Add("rAM");
            list.Add("Shyam");
            list.Add("shyam");
            list.Add("shyam krishna");
            list.Add("hari");
            list.Add("hari krishna");
            return list;
        }
        public static List<string> Contain(string subname, List<string> list)
        {
            return list.Where(subject=> subject.Contains(subname)).ToList();
        }
        public static List<string> startWith(string subname, List<string> list)
        {

            return list.Where(subject => subject.ToUpper(). StartsWith(subname.ToUpper())).ToList();
        }
        static List<string> Equals(string subname, List<string> list)
        {

            return list.Where(subject => subject.ToUpper().Equals(subname.ToUpper())).ToList();
        }

    }
}