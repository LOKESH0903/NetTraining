using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class MathsCalculations
    {

        public int MathsResult(int a, int b, int type )
        {

            // Test check in
            int result = 0;

    
            switch(type)
            {
                case 1:
                    result = Addition(a, b);
                    break;
                case 2:
                    result = Subtraction(a, b);
                    break;
                case 3:
                    result = Multiplication(a, b);
                    break;
                case 4:
                    result = Division(a, b);
                    break;
                default:
                    result = 0;
                    break;
            }

       


            //if(type == 1)
            //{
            //    result = Addition(a, b);
            //}
            //else if (type == 2)
            //{
            //    result = Subtraction(a, b);
            //}
            //else if (type == 3)
            //{
            //    result = Multiplication(a, b);
            //}
            //else if (type == 4)
            //{
            //    result = Division(a, b);
            //}

            return result ;





            //switch(type)
            //{
            //    case 1:
            //        return Addition(a, b);

            //    default:
            //        return 0; 
            //}
        }

     
        public int Addition(int a, int b)
        {
                return a + b;
        }

        public int Subtraction(int a , int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            int c =  a * b;
            return c;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }

    class Pets
    {
        public void PetDetails(ref string names)
        {
            if( !string.IsNullOrEmpty(names) && names.ToLower() == "dog")
            {
                Console.WriteLine("I am dog...");
            }
            //else
            //{
            //    names = "cat";
            //}    

            names = "horse";
        }

        public void PetsName(string _name = "hen")
        {
            Console.WriteLine("Default parameter value : " + _name);
        }


        public void AllPetDetails(out string finalName, string name, string defaultName = "cat")
        {
            finalName = "GOAT";
        }
    }

    class methodoverloading
    {
        public int Addition()
        {
            return 10 + 20;
        }


        public int Addition(int a)
        {
            return a;
        }

        public double Addition(double a)
        {
            return a;
        }

        public void Addition(out int returnValue)
        {
            returnValue = 10 + 40;
        }

        public int Addition(int a, int b)
        {
            return a + b;
        }
    }
}

