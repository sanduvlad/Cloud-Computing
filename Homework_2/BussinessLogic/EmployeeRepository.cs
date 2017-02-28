using Homework_2.Classes;
using Homework_2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_2.BussinessLogic
{
    public class EmployeeRepository
    {
        public static EmployeeRepository _instance;

        private EmployeeContext empContext = new EmployeeContext();
        public static EmployeeRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeeRepository();
                }
                return _instance;
            }
        }

        private EmployeeRepository()
        {
            empContext = new EmployeeContext();
            BuildListOnce();
        }

        public List<Employee> GetAllEmployees()
        {
            return empContext.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return empContext.Employees.Single(e => e.Id == id);
        }

        public Employee AddNewEmployee(Employee emp)
        {
            empContext.Employees.Add(emp);
            return emp;
        }

        public Employee ModifyEmployee(Employee emp)
        {
            Employee contextEmp = empContext.Employees.Single(e => e.Id == emp.Id);
            if (contextEmp == null)
            {
                return null;
            }
            else
            {
                contextEmp.Name = emp.Name;
                contextEmp.Phone = emp.Phone;
                return emp;
            }
        }

        public List<Employee> DeleteEmployee(int id)
        {
            bool deleted = false;
            for (int i = 0; i < empContext.Employees.Count; i++)
            {
                if (empContext.Employees[i].Id == id)
                {
                    empContext.Employees.RemoveAt(i);
                    deleted = true;
                    break;
                }
            }
            if (deleted == false)
            {
                return null;
            }
            else
            {
                return GetAllEmployees();
            }
        }

        private void BuildListOnce()
        {
            empContext.Employees.Add(new Employee() { Id = 1, Name = "Jules", Phone = "076" });
            empContext.Employees.Add(new Employee() { Id = 2, Name = "Wiliam", Phone = "075" });
            empContext.Employees.Add(new Employee() { Id = 3, Name = "Fred", Phone = "072" });
            empContext.Employees.Add(new Employee() { Id = 4, Name = "Wilma", Phone = "073" });
            empContext.Employees.Add(new Employee() { Id = 5, Name = "Rubble", Phone = "074" });
        }
    }
}