using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealclass
{
    public sealed class newclass
    {
        public string name {  get; set; }
        public string description { get; set; }
    }
    public class newclass2 : newclass
    {
        public string name { get; set; }
    }
}
