using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTPLibrary
{
    public class Employee : Person
    {
        //FIELDS

        //PROPERTIES

        public int Id { get; /*set;*/ }     //READONLY
        public string JobTitle { get; set; }
        public DateTime DateOfHire { get; set; }
        public bool IsDirectDeposit { get; set; }

        //CTOR

        public Employee(string firstName, string lastName, DateTime dob, int id, string jobTitle, DateTime dateOfHire, bool isDirectDeposit)
            : base(firstName, lastName, dob)
        {
            Id = id;
            JobTitle = jobTitle;
            DateOfHire = dateOfHire;
            IsDirectDeposit = isDirectDeposit;
        }

        //METHODS

        public override string ToString()
        {
            return string.Format($"Employee ID: {Id}\n{base.ToString()}\nTitle: {JobTitle}\nHireDate: {DateOfHire:d}\nDirect Deposit? {IsDirectDeposit}");
        }
    }
}
