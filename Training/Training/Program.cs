using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsCalculations mat = new MathsCalculations();
            int result = mat.MathsResult(30, 10, 2);

            Console.WriteLine("The result " + result.ToString());


            /*
         switch(expression)
       {
           case 0:
               logic 
           break
           case 1:
               logic 
           break;

          default:
           break;
       }
        */
            //string xyz = "";
            //string abc = "hi";
            //switch (abc)
            //{
            //    case "hello":
            //        xyz = "hello";
            //        break;
            //    case "hi":
            //        xyz = "hi";
            //        break;
            //    default:
            //        xyz = "bye";
            //        break;
            //}

            //Console.WriteLine("Result based on selected Switch  " + xyz);

            /*
             1 Add
             2 Sub  
             3 Mul
             4 Div
             */


            //int additionResult = mat.Addition(1, 2);

            //int SubtractionResult = mat.Subtraction(1, 2);

            //int MultipResult = mat.Multiplication(1, 2);

            //double DivisionResult = mat.Division(1, 2);


            //Console.WriteLine("The addition value is : " + additionResult.ToString());

            //Console.WriteLine("The addition value is : " + SubtractionResult.ToString());

            //Console.WriteLine("The addition value is : " + MultipResult.ToString());

            //Console.WriteLine("The addition value is : " + DivisionResult.ToString());

            Console.ReadLine();
        }
    }
}
