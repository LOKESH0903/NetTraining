using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Shop
    {
        public string ShopeName = "Toys";
        public void ShopGoods()
        {
            Console.WriteLine("Kids toys"); 
        }

        public void ShopDetails()
        {
            Console.WriteLine("I am parent class method"); ;
        }
    }

    public class WholesSales   : Shop
    {
        public new void ShopDetails()
        {
            Console.WriteLine("I am child class method"); ;
        }

        public void WholeSaleDetails()
        {
            Console.WriteLine("I am wholesaale Shop."); ;
        }
    }

    public class Retailer : WholesSales
    {
        public void RetailDetails()
        {
            Console.WriteLine("I am Retail Shop, I also having toys"); ;
        }
    }




}
