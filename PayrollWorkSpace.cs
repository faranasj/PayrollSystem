using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public static class PayrollWorkSpace
    {
        // public static string PrintOverallPayment()
        // {
        //     Console.Write("How many days do you work in a week: ");
        //     int daysOfWeek = int.Parse(Console.ReadLine());
        //     Console.WriteLine("How many hours do you work in a day: ");

        //     decimal overTimePay = 1;
        //     decimal netEarning;
        //     int sumOfHours = 0;  
        //     int sumOfOvertimeHours = 0; 

        //     for (int count = 1; count <= daysOfWeek; count++)
        //     {
        //         Console.Write($"Day {count}: ");
        //         int noOfHours = int.Parse(Console.ReadLine());
        //         Console.Write($"How many overtime hour did you work in day {count}?: ");
        //         int overtimeHour = int.Parse(Console.ReadLine());
        //         Console.Clear();
        //         sumOfHours += noOfHours;
        //         sumOfOvertimeHours += overtimeHour;
        //     }
            
        //     overTimePay = sumOfOvertimeHours * 10;
        //     decimal weeklyPay = (sumOfHours * 25) + overTimePay;
        //     decimal grossEarning = weeklyPay * 4;

        //     if (grossEarning < 1000)
        //     {
        //         netEarning = grossEarning - (1.5m/100) * grossEarning;
        //     }            
        //     else if (grossEarning > 1000 || grossEarning <= 2500)
        //     {
        //         netEarning = grossEarning - (2.5m/100) * grossEarning;
        //     }
        //     else
        //     {
        //         netEarning = grossEarning - (4.5m/100) * grossEarning;
        //     }

        //     Console.WriteLine("===== Payroll System =====");
        //     Console.WriteLine();
        //     Console.WriteLine($"Hours worked is = {sumOfHours}\nOvertime hours worked is = {sumOfOvertimeHours}\nWeek pay = ${weeklyPay}\nOvertime pay per week is = ${overTimePay}\nGross earning = ${grossEarning}\nNet earning = ${netEarning}");    
        //     Console.WriteLine();       
        // }
    }
}