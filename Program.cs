using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Program
    {
        private static readonly Compilation _work = new Compilation();
        static void Main(string[] args)
        {
            // try 
            // {
            //     Compilation work = new(); // instead of writing the class name after the new, you can just end it with new.
            //     Console.Write("Enter the number of days worked: ");
            //     _work.NoOfDaysWorked = int.Parse(Console.ReadLine());
            //     // var result = work.GetTotalNumberOfHoursWorked();
               
            //     var result = _work.PaymentCalculations();
            //     Console.Clear();

            //     Console.WriteLine(result);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // PayrollWorkSpace.PrintOverallPayment();

            var employeeList = new List<Employee>()
            {
                new Employee() 
                {
                    Id = 1,
                    EmployeeCode = Helper.GenerateCode(),
                    FirstName = "Ade",
                    MiddleName = "Kola",
                    LastName = "Adekola",
                    DateJoined = DateTime.Now,
                },
                new Employee() 
                {
                    Id = 2,
                    EmployeeCode = Helper.GenerateCode(),
                    FirstName = "Mariro",
                    MiddleName = "Mata",
                    LastName = "Matepo",
                    DateJoined = DateTime.Now,
                },
                new Employee() 
                {
                    Id = 3,
                    EmployeeCode = Helper.GenerateCode(),
                    FirstName = "Wa",
                    MiddleName = "Nbi",
                    LastName = "Bai",
                    DateJoined = DateTime.Now,
                },
                new Employee()
                {
                    Id = 4,
                    EmployeeCode = Helper.GenerateCode(),
                    FirstName = "Kora",
                    MiddleName = "Re",
                    LastName = "Kuro",
                    DateJoined = DateTime.Now,
                },
            };

            var employee = new EmployeeService();

            // var newEmployee = new Employee() 
            var list = employee.ListAllEmployee();  

            // employee.CreateEmployee(newEmployee);

            // Console.WriteLine(employeeList);

            foreach (var item in employeeList)
            {
                Console.WriteLine($"{item.EmployeeCode}\n{item.FirstName} {item.MiddleName} {item.LastName}\n{item.DateJoined}");
            }
            
            

           
        }
    }
}
