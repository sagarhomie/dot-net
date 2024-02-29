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
            list1=Equals("net",list);
            list2 = startWith("c", list);
            list3 = Contain("put", list);
            Console.WriteLine("*****string which is equals to net*****");
            foreach (string subname in list1)
             {   
               Console.WriteLine(subname);
             }
            Console.WriteLine("*****string which is start with to c*****");
            foreach (string subname in list2)
            {
                
                Console.WriteLine(subname);
            }
            Console.WriteLine("*****string which  contain to t*****");
            foreach (string subname in list3)
            {
                Console.WriteLine(subname);
            }
            Console.ReadKey();
        }
        
       public static List<string> getList()
        {
            List<string> list = new List<string>();
            list.Add("Net");
            list.Add("Centric");
            list.Add("Computing");
            list.Add("NET");
            list.Add("CENTRIC");
            list.Add("COMPUTING");
            list.Add("net");
            list.Add("centric");
            list.Add("computing");
            list.Add("nET");
            list.Add("cENtric");
            list.Add("cOMPUTING");
            return list;
        }
        public static List<string> Contain(string subname,List<string> list)
        {
            return(from subject in list where subject.Contains(subname) select subject).ToList();
        }
        public static List<string> startWith(string subname,List<string> list)
        {
            
            return (from subject in list where subject.ToUpper().StartsWith(subname.ToUpper()) select subject).ToList();
        }
        static List<string> Equals(string subname,List<string> list) {
         
            return (from subject in list where subject.ToUpper().Equals(subname.ToUpper()) select subject).ToList();
        }
        
    }
}
