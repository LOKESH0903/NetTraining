using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsCalculations mat = new MathsCalculations();

           int result = mat.Addition(1, 2);

            Console.WriteLine("The addition value is : " + result.ToString());

            Console.ReadLine();
        }
    }
}
