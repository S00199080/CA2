using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{    //This is the Employee Class
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        


        public abstract void CalculateMonthlyPay(decimal monthlyPay);                      
    }

    //FullTimeEmployee inherits from Employee
    public class FullTimeEmployee : Employee
    {
        
        public FullTimeEmployee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
         
        }

        public decimal Salary { get; set; }

        //Override method
        public override void CalculateMonthlyPay(decimal salary)
        {
            Salary = salary * 12;
        }

        public override string ToString()
        {
            return string.Format($"{LastName}, {FirstName} - Salary {Salary}");
        }
    }

    //PartTimeEmployee inherits from Employee
    public class PartTimeEmployee : Employee
    {
        public decimal MonthlyPay { get; set; }
        public PartTimeEmployee(string firstName, string lastName, decimal hourlyRate, decimal hoursWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;

            MonthlyPay = (hourlyRate * hoursWorked);

        }
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }

        public override void CalculateMonthlyPay(decimal monthlyPay)
        {
            MonthlyPay = monthlyPay;
        }

        public override string ToString()
        {
            return string.Format($"{LastName}, {FirstName} - MonthlyPay {MonthlyPay}");
        }

    }
}
