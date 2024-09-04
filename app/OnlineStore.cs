using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class OnlineStore
    {
        private string name;
        private List<Product> products;

        //online store that works with many countries. Each country has different account setting, and regulations
        // and if we want to set it fit to every country it's becomes problem. 

        public override string ToString()
        {
            return $"Store:[name={name},products=\n{string.Join("\n",products)}]";
        }
    }
}
