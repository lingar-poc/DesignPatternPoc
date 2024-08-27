using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class Store
    {
        private string name;
        private List<Product> products;

        public override string ToString()
        {
            return $"Store:[name={name},products=\n{string.Join("\n",products)}]";
        }
    }
}
