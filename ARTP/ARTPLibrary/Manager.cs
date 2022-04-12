using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTPLibrary
{
    public class Manager : SalariedEmployee
    {
        //FIELDS

        //PROPERTIES

        public decimal Bonus { get; set; }

        //CTOR

        public Manager(string firstName, string lastName, DateTime dob, int id, string jobTitle, DateTime dateOfHire, bool isDirectDeposit, decimal annualSalary, decimal bonus)
            : base(firstName, lastName, dob, id, jobTitle, dateOfHire, isDirectDeposit, annualSalary)
        {
            Bonus = bonus;
        }

        //METHODS

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nQuarterly Bonus: {Bonus:c}");
        }

    }
}
