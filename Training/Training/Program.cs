using System;
using System.Collections.Generic;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsCalculations mat = new MathsCalculations();
            //const string January = "1";
            //January = "2";
            //Console.WriteLine("The January value : " + January);
            //Console.WriteLine("Please enter the value : ");
            //string numbera = Console.ReadLine();
            //int number = int.Parse(numbera);
            //switch (number)
            //{
            //    case (int)Months.Jan:
            //        Console.WriteLine("Month of January");
            //        break;
            //    case (int)Months.Feb:
            //        Console.WriteLine("Month of February");
            //        break;
            //    case (int)Months.Mar:
            //        Console.WriteLine("Month of March");
            //        break;
            //    case (int)Months.Apr:
            //        Console.WriteLine("Month of Apriil");
            //        break;
            //    case (int)Months.May:
            //        Console.WriteLine("Month of May");
            //        break;
            //    case (int)Months.June:
            //        Console.WriteLine("Month of June");
            //        break;
            //    case (int)Months.July:
            //        Console.WriteLine("Month of July");
            //        break;
            //    case (int)Months.Aug:
            //        Console.WriteLine("Month of August");
            //        break;
            //    case (int)Months.Sep:
            //        Console.WriteLine("Month of September");
            //        break;
            //    case (int)Months.Oct:
            //        Console.WriteLine("Month of October");
            //        break;
            //    case (int)Months.Nov:
            //        Console.WriteLine("Month of November");
            //        break;
            //    case (int)Months.Dec:
            //        Console.WriteLine("Month of JaDecembernuary");
            //        break;
            //    default:
            //        Console.WriteLine("Out of range");
            //        break;
            //}

            TestClass tst = new TestClass();
            tst.StudentId = 100;
            tst.StudentName = "Rahul";


            Console.WriteLine(tst.StudentName);

            tst.StudentId = 200;
            tst.StudentName = "drav";












            //Console.WriteLine("The month of " + Months.Jan  + " number is " + (int)Months.Jan);
            //Console.WriteLine("The month of " + Months.Feb + " number is " + (int)Months.Feb);

            //int result = mat.MathsResult(30, 10, (int)MathsEnum.Addition);
            //Console.WriteLine("The result " + result.ToString());


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
