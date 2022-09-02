using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class EmployeeService : IEmployee // inherited from interface and all methods in this class was imported and arranged alphabetically
    {
        public List<Employee> employees = new List <Employee>(); // here the employees object was instantiated and Employee was made a data type. 

        public void CreateEmployee(Employee employee)
        {
            employee.EmployeeCode = Helper.GenerateCode();
            employee.DateJoined  = DateTime.Now;

            var findEmployee = FindByIdOrCode(employee.Id, employee.EmployeeCode);

            if (findEmployee == null)
            {
                employees.Add(employee);

                Console.WriteLine("Employee account created succesfully!");
            }
            else
            {
                Console.WriteLine("Employee account already exist!");
            }   
        }

        public void DeleteEmployee(int id)
        {
           var employee = employees.Find(i => i.Id == id);
           if (employee != null)
           {
               employees.Remove(employee);
               Console.WriteLine($"Succesfully deleted employee account with Id: {id} and Name: {employee.LastName}, {employee.FirstName} {employee.MiddleName} !");
           }
           else
           {
               Console.WriteLine("NOT FOUND!!!");
           }
        }

        public Employee FindByIdOrCode(int? id = null, string code = null)
        {
            return employees.Find(i => i.Id == id || i.EmployeeCode == code);
        }

        public List<Employee> ListAllEmployee()
        {
            return employees;
        }

        public Employee UpdateEmployee(int id, Employee model)
        {
            var employee = employees.Find(i => i.Id == id);

            if (employee != null)
           {
               employee.FirstName = model.FirstName;
               employee.MiddleName = model.MiddleName;
               employee.LastName = model.LastName;
               employee.DateJoined = model.DateJoined;
               
               Console.WriteLine($"Employee succesfully updated.");
           }
           else
           {
               Console.WriteLine("NOT FOUND!!!");
           }
           return employee;
        }

        public Employee ViewEmployee(int id)
        {
            var employee = employees.Find(i => i.Id == id);
            return employee;
        }

       
    }
}