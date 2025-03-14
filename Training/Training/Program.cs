using System;
using System.Collections.Generic;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetails U = new UserDetails();
            try
            {
                U.SetAgeValue(10);
                Console.WriteLine("Age: " + U.GetAgeValue());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
