using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTPLibrary
{
    public class SalariedEmployee : Employee
    {
        //FIELDS

        //PROPS

        public decimal AnnualSalary { get; set; }

        //CTOR

        public SalariedEmployee(string firstName, string lastName, DateTime dob, int id, string jobTitle, DateTime dateOfHire, bool isDirectDeposit, decimal annualSalary)
            : base(firstName, lastName, dob, id, jobTitle, dateOfHire, isDirectDeposit)
        {
            AnnualSalary = annualSalary;
        }

        //METHOD

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nAnnual Salary: {AnnualSalary:c}");
        }

    }
}
