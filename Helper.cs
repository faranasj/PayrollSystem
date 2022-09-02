using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public static class Helper
    {
        public static string GenerateCode()
        {
            Random rand = new();
            return $"EMP-{rand.Next(999999)}";
        }


    }
}