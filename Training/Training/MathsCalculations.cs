﻿using System;
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

            return result;





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
}
