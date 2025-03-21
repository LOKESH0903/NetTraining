using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class ToysSupplier
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Kids zone...");
        }
        public void DisplayName(string name)
        {
            Console.WriteLine("I am Supplier...");
        }


        public void ShopName()
        {
            Console.WriteLine("This is Supplier Shop.");
        }


        public virtual void ShoreAreaName(string name)
        {
            Console.WriteLine("This is Supplier - Hyd.");
        }

       
    }

    public class FirstCry : ToysSupplier
    {
        public  void DisplayName()
        {
            Console.WriteLine("I am Firstcry store...");
        }

        public new void ShopName()  // method hiding
        {
            Console.WriteLine("This is First cry store.");
        }

        public override void ShoreAreaName(string name)
        {
            Console.WriteLine("This is Frist Cry - BZA.");
        }


    }
}
