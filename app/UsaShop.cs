using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_Akiva_Cohen.bank_app;

namespace DesignPatternPoc.app
{
    public class UsaShop : OnlineStore
    {
        public override IAccount CreateAccount()
        {
            return new UsaAccount(null, 0,0 );
        }
        //another implementation goes here... 
    }
}
