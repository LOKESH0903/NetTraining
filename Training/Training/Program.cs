using System;
using System.Collections.Generic;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetails U = new UserDetails();
            //U.SetNameValue("Krishna");
            Console.WriteLine("The name value : " + U.GetNameValue());
            Console.ReadLine();
        }
    }
}
