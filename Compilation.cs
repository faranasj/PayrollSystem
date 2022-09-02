using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class Compilation
    {
        public decimal NormalHourlyRate { get { return 25; } } // readonly constructor
        public decimal OvertimeHourlyRate { get { return 10; } }
        public int HoursWorked { get; set; }
        public int OverTimeWorked { get; set; }
        public int NoOfDaysWorked { get; set; }
        public decimal MonthlyGrossPay { get; set; }
        public decimal WeeklyGrossPay { get; set; }
        public decimal MonthlyNetPay { get; set; }
        public decimal Deduction { get; set; }
        const int MAXIMUMHOURSWORKED = 8; // used all caps for constant variables
        
        public string PaymentCalculations()
        {
            var hoursWorked = GetTotalNumberOfHoursWorked(NoOfDaysWorked);
            HoursWorked = hoursWorked.Item1; // Item1 is used to get result of tuple
            OverTimeWorked = hoursWorked.Item2;

            MonthlyGrossPay = (NormalHourlyRate * HoursWorked) + (OvertimeHourlyRate * OverTimeWorked);

            WeeklyGrossPay = MonthlyGrossPay / 4;

            MonthlyNetPay = MonthlyGrossPay - TaxCalculation(MonthlyGrossPay);

            Deduction = TaxCalculation(MonthlyGrossPay);

            return $"Normal Hours Worked: {HoursWorked}hrs\nOvertime Hours Worked: {OverTimeWorked}hrs\nWeekly Gross: ${WeeklyGrossPay}\nMonthly Gross: ${MonthlyGrossPay}\nNet Earning: ${MonthlyNetPay}\nTax Deducted: ${Deduction}";
        }

         private decimal TaxCalculation(decimal monthlyGrossPay) // the standard is to write private methods after public methods.
        {
            decimal taxRate = 0.00m;

            if (monthlyGrossPay <= 1000)
            {
                taxRate += monthlyGrossPay * 1.5m/100;
            }   
            else if (monthlyGrossPay > 1000 && monthlyGrossPay <= 2500)
            {
                taxRate += monthlyGrossPay * 2.5m/100;
            }
            else if (monthlyGrossPay > 2500)
            {
                taxRate += monthlyGrossPay * 4.5m/100;
            }

            return taxRate;  
        }
        
        private Tuple<int, int> GetTotalNumberOfHoursWorked(int noOfDaysWorked)
        {
            int sumOfNormalHoursWorked = 0;
            int sumOfOvertimeWorked = 0;
            int normalHoursWorked = 0;

            for (int i = 1; i <= noOfDaysWorked; i++)
            {
                Console.Write($"Enter hours worked for day {i}: ");
                int hoursWorked = int.Parse(Console.ReadLine());
                // sumOfNormalHoursWorked += hoursWorked;

                if(hoursWorked > 15)
                {
                    hoursWorked = 15;
                }
                if (hoursWorked > MAXIMUMHOURSWORKED)
                {
                    sumOfOvertimeWorked += hoursWorked - MAXIMUMHOURSWORKED;
                }
                normalHoursWorked += hoursWorked;

                sumOfNormalHoursWorked = normalHoursWorked - sumOfOvertimeWorked;
            }
            var result = Tuple.Create<int, int>(sumOfNormalHoursWorked, sumOfOvertimeWorked); // you can use tuple.create to instantiate a tupple instead of new.
            return result;
        }
 
    }
}