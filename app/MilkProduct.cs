using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class MilkProduct : Product
    {

        public MilkProduct(IProductsRequiresFactory productsRequiresFactory) : base(productsRequiresFactory)
        {
        }
    }
}
