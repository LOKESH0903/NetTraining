using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsCalculations mat = new MathsCalculations();

            int additionResult = mat.Addition(1, 2);

            int SubtractionResult = mat.Subtraction(1, 2);

            int MultipResult = mat.Multiplication(1, 2);

            double DivisionResult = mat.Division(1, 2);


            Console.WriteLine("The addition value is : " + additionResult.ToString());

            Console.WriteLine("The addition value is : " + SubtractionResult.ToString());

            Console.WriteLine("The addition value is : " + MultipResult.ToString());

            Console.WriteLine("The addition value is : " + DivisionResult.ToString());

            Console.ReadLine();
        }
    }
}
