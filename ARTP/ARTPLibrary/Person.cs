using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTPLibrary
{
    public class Person
    {
        //FIELDS

        //Field conventions:
            // - Private
            // - _camelCase

        //Convention vs Rule: 
        //Convention should be followed - has no compiler-enforced ramifications.
        //Rule MUST be followed - uses the compiler to enforce the rules
        
        private string _firstName;
        private string _lastName;
        private DateTime _dob;

        //PROPERTIES

        public string FirstName
        {
                //Manually refactored property -> these are the details that are hidden with encapsulated automatic properties
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }       //CONTAINMENT complex

        //CTOR
        //Conventions: should be public - MOST ctors you deal with will be public
        //Rules: Name MUST match the class name - spelling AND casing

        public Person(string firstName, string lastName, DateTime dob)
        {
            //assignment of values
            //Property   "is assigned the value of"   parameter
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
        }


        //METHODS

        public override string ToString()
        {
            //return "Name: " + FirstName + " " + LastName + "\nDate of Birth: " + DOB;

            return string.Format($"Name: {FirstName} {LastName} \nDate of Birth: {DOB:d}");
        }


    }
}
