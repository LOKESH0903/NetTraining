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

        public void SetIdValue(int _id)
        {
            if (_id <= 0)
            {
                throw new Exception("Id should not be less than 0");
            }

            this.Id = _id;
        }

        public int GetIdValue()
        {
            return this.Id;
        }

        public void SetNameValue(string _name)
        {

            if(string.IsNullOrEmpty(_name))
            {
                throw new Exception("Name should not be empty");
            }

            this.Name = _name;
        }

        public string GetNameValue()
        {
            //if(string.IsNullOrEmpty(this.Name))
            //{
            //    return "Name not assigned!";
            //}
            //return this.Name;
            //return string.IsNullOrEmpty(this.Name) ? "Name not assigned!" : this.Name;


            return !string.IsNullOrEmpty(this.Name) ? this.Name : "Name not assigned!";
        }


    }
}
