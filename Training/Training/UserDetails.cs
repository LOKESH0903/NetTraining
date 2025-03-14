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
        private string message;

        public void SetAgeValue(int _age)
        {
            if (_age <= 18)
            {
                this.message = "Age should not be less than 18";
            }

            this.age = _age;
        }

        
        public int GetAgeValue(out string message)
        {
            message = this.age <= 18 ? "not Possiable to vote" : " User can Vote... ";
            return this.age;
        }

        public int UserAge
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

        public string UserInformation
        {
            get
            {
                return  "User age is "+ age.ToString() + "  " + message;
            }
        }
    }
}
