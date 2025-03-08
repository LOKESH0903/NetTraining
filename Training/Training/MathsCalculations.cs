using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class MathsCalculations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">-1</param>
        /// <param name="b">2</param>
        /// <returns></returns>
        public int Addition(int a, int b)
        {
            if(a > 0 && b > 0)
            {
                return a + b;
            }

            return 0;
        }
    }
}
