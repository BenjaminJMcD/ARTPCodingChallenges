using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTPLibrary
{
    public class HourlyEmployee : Employee
    {
        //FIELDS

        //PROPERTIES

        public int HoursWorked { get; set; }
        public decimal HourlyWage { get; set; }

        //CTOR

        public HourlyEmployee(string firstName, string lastName, DateTime dob, int id, string jobTitle, DateTime dateOfHire, bool isDirectDeposit, int hoursWorked, decimal hourlyWage)
            : base(firstName, lastName, dob, id, jobTitle, dateOfHire, isDirectDeposit)
        {
            HoursWorked = hoursWorked;
            HourlyWage = hourlyWage;
        }

        //METHODS

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\n\nHours Worked: {HoursWorked}\nHourly Wage: {HourlyWage:c}");
        }
    }
}
