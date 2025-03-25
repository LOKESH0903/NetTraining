using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public abstract class ExampleAbstract
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

        public abstract void PrintCaptialName(int a, int b);
        
    }

    public class AndhraState : ExampleAbstract
    {
        public void Printabc()
        {
            Console.WriteLine("Print");
        }

        public override void PrintCaptialName(int a, int b)
        {
            Console.WriteLine("BZA.");
        }
    }

    public class dist : AndhraState
    {
        public new void Printabc()
        {
            Console.WriteLine("Print bhimave");
        }
    }

    public class Telangana : ExampleAbstract
    {
        public override void PrintCaptialName(int a, int b)
        {
            Console.WriteLine("HYD.");
        }
    }
}
