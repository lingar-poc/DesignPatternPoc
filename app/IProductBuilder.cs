using c_sharp_apps_Akiva_Cohen.bank_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public interface IProductBuilder
    {

        void Reset();
        void BuildName();
        void BuildPackage();
        void BuildPrice();
        void BuildManufacture();

        Product Build();



    }
}
