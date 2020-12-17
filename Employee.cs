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


    public class FullTimeEmployee : Employee
    {
        
        public FullTimeEmployee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
         
        }

        public decimal Salary { get; set; }

        public override void CalculateMonthlyPay(decimal salary)
        {
            Salary = salary * 12;
        }

        public override string ToString()
        {
            return string.Format($"{LastName}, {FirstName} - Salary {Salary}");
        }
    }

    public abstract class PartTimeEmployee : Employee
    {
        public decimal MonthlyPay { get; set; }
        public PartTimeEmployee(string firstName, string lastName, decimal hourlyRate, decimal hoursWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;

        }
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }

        public void CalculateMonthlyPay(decimal hoursWorked, decimal hourlyRate)
        {
            MonthlyPay = (hourlyRate*hoursWorked);
            
            
        }

        public override string ToString()
        {
            return string.Format($"{LastName}, {FirstName} - MonthlyPay {MonthlyPay}");
        }

    }
}
