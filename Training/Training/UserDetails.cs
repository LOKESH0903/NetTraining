using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class UserDetails
    {
        private int Id;
        private string Name;
        private int age;

        public void SetAgeValue(int _age)
        {
            if(_age <= 18)
            {
                throw new Exception("Age should not be less than 18");
            }
            this.age = _age;

        }
       // public int GetAgeValue()
       // {
       //     return this.age;
       // }

        public int GetAgeValue()
        {
            if (int.MinValue ==this.age)
            {
                return  -1 ;
            }
            return this.age;
        }


       


    }
}
