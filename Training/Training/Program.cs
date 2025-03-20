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
                WholesSales w = new WholesSales();


                w.ShopDetails();


                ((Shop)w).ShopDetails();

                Shop s = new WholesSales();

                WholesSales w1 = new Shop();


                s.ShopDetails();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
