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
                U.SetAgeValue(17);
                // string msg;
                // Console.WriteLine("Age:  " + U.GetAgeValue(out msg));
                // Console.WriteLine("Message : " + msg);

                Console.WriteLine(" " + U.UserInformation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
