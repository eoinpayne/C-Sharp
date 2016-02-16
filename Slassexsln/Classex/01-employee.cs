using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classex
{
    public class Employee // accessibility: public = means everyone can see it. private =needs access
    {
        //auto-implemented properties, if you need to future validate, 
        //then throw in backing field as normal and add in getter/setter
        public int Ssn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        private string phoneNumber;         //backing field
        public string PhoneNumber           //property that included validation
        {
            get { return phoneNumber; }
            set{
                if (value.Length != 10) phoneNumber = "";
                else phoneNumber = value;
            }
        }

        public Employee() //default constructor
        {
            Name = "";
            phoneNumber = "0871234";
            Ssn = 11;
        }

        public Employee(string name)    //can have multiple constructors
        {
            this.Name = name;           //this name means for THIS objects, this is the name
                    }

        public Employee(string name, string phoneNumber) //can have multiple constructors
        {
            this.Name = name;           //this name means for THIS objects, this is the name
            this.phoneNumber = phoneNumber;

            if (phoneNumber.Length != 10) phoneNumber = "";
            else this.phoneNumber = phoneNumber;
        }

    }
}

//what is data
//what is functionality
