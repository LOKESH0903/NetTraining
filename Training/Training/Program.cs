using System;
using System.Collections.Generic;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //WholesSales w = new WholesSales();
                //w.ShopDetails();
                //((Shop)w).ShopDetails();
                //w.ShopDetails();
                //Shop s = new WholesSales();

                /*
                 inheritance (base - child classs)
                method hiding
                method overloading
                method overriding  (Virtual)


                abstract
                interfaces

                 
                 */

                methodoverloading m = new methodoverloading();
                int a;
                m.Addition(out a);
                Console.WriteLine("no parameterss : " + m.Addition());
                Console.WriteLine("no parameterss : " + m.Addition(15.6));
                Console.WriteLine("no parameterss : " + m.Addition(2));
                Console.WriteLine("no parameterss : " + a);
                Console.WriteLine("no parameterss : " + m.Addition(2, 9));







            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
