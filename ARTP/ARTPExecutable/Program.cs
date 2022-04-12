using ARTPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTPExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Jacobs", new DateTime(1989,10,03));
            Console.WriteLine(p);

            Console.WriteLine("\n\n*** Employee Object ***\n\n");

            Employee e = new Employee("George", "Geffers", new DateTime(1964, 11, 25), 1111, "Author", new DateTime(2007, 12, 02), true);

            Console.WriteLine(e);

            Console.WriteLine("\n\n*** Hourly Employee ***\n\n");

            HourlyEmployee h = new HourlyEmployee("Jimmy's", "John's", new DateTime(1975, 05, 05), 1112, "Sammich Maker", new DateTime(2020, 07, 05), true, 40, 7.27m);

            Console.WriteLine(h);

            Console.WriteLine("\n\n*** Salaried Employee ***\n\n");

            SalariedEmployee s = new SalariedEmployee("Joe", "Schmoe", new DateTime(1965, 02, 25), 1113, "Executive", new DateTime(2020, 07, 30), true, 32000);

            Console.WriteLine(s);

            Console.WriteLine("\n\n*** Manager ***\n\n");

            Manager m = new Manager("Papa", "Giorgio", new DateTime(1951, 03, 17), 1110, "Manager", new DateTime(2021, 07, 21), true, 65000, 2000);




            Console.WriteLine(m);
        }
    }
}
