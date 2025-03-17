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

                string petName = null;  // dog ( Dog -> dog
                Pets P = new Pets();
                P.PetDetails(ref petName); // passing the value types by reference.

                P.PetsName("cat");
                P.PetsName();

                P.AllPetDetails(out petName, "Goat", "rat");
                P.AllPetDetails(out petName, "Goat");

                /*
                 * in parameters (normal , value).
                 * out
                 * ref
                 * optional / default 
                 * dynamic
                 * params
                 */


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
