using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class MilkProductsRequiresFactory : IProductsRequiresFactory
    {
        public IExpiration CreateExpiration()
        {
            MilkExpirationDate m = new MilkExpirationDate();
            //Some logic...
            return m;
        }

        public ISku CreateSku()
        {
            IsraelSKU s = new IsraelSKU();
            //Some logic...

            return s;
        }

        public IWeight CreateWeight()
        {
            BasicWeight b = new BasicWeight();
            //some logic...
            return b;
        }
    }
}
