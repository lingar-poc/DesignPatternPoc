using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Abstract factory
namespace DesignPatternPoc.app
{
    public interface IProductsRequiresFactory
    {
        ISku CreateSku();

        IWeight CreateWeight();

        IExpiration CreateExpiration();

    }
}
