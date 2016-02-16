using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classex
{
    public class Employee // accessibility: public = means everyone can see it. private =needs access
    {
        private string phoneNumber;

        //auto-implemented properties, if you need to future validate, 
        //then throw in backing field as normal and add in getter/setter
        public int Ssn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 

        //getter setter -- propoerty
        public string Name // no need to list paramater. Whatever is passed in will be sent to "value"
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length != 10) phoneNumber = "";
                else phoneNumber = value;
            }
        }

        public int Ssn
        {
            get { return ssn; }
            private set //can only be set from within the class
            {
                if (value.Length != 10) phoneNumber = "";
                else phoneNumber = value;
            }
        }

        public Employee() //default constructor
        {
            name = "";
            phoneNumber = "0871234";
            ssn = 11;
        }

        public Employee(string name) //can have multiple constructors
        {
            this.name = name; //this name means for THIS objects, this is the name
                    }

        public Employee(string name, string phoneNumber) //can have multiple constructors
        {
            this.name = name; //this name means for THIS objects, this is the name
            this.ssn = ssn;

            if (phoneNumber.Length != 10) phoneNumber = "";
            else this.phoneNumber = phoneNumber;
        }

    }
}

//what is data
//what is functionality
