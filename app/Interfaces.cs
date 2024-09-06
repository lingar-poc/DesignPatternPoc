using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DesignPatternPoc.app
{
    public class Interfaces
    {
    }




    //Interfaces of the factory Products
    public interface ISku
    {
        string GenerateSKU();
    }

    public interface IWeight
    {
        int GetWeight();

    }

    public interface IExpiration
    {
        void CalcaulateExpiration();
    }
}
