using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public abstract void CalculateMonthlyPay(decimal monthlyPay);
       
        
        
    }


    public abstract class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override void CalculateMonthlyPay(decimal salary)
        {
            Salary = salary * 12;
        }

    }

    public abstract class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public void CalculateMonthlyPay(decimal hoursWorked, decimal hourlyRate)
        {
            HourlyRate = (hourlyRate*hoursWorked);
        }
    }
}
