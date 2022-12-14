using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class Employee 
    {
        public int Id { get; set; } // these are called auto implemented properties

        public string EmployeeCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime DateJoined { get; set; }
    }
}