using Homework_2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_2.DataModel
{
    public class EmployeeContext
    {
        public List<Employee> Employees { get; set; }

        public EmployeeContext()
        {
            Employees = new List<Employee>();
        }
    }
}