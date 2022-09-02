using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public interface IEmployee
    {
        void CreateEmployee(Employee employee);

         public List<Employee> ListAllEmployee(); // declarat

         Employee ViewEmployee(int id);

        Employee UpdateEmployee(int id, Employee model);

        void DeleteEmployee(int id);

        Employee FindByIdOrCode(int? id = null, string code = null);
    }
}