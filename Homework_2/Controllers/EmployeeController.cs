using Homework_2.BussinessLogic;
using Homework_2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Homework_2.Controllers
{
    //[Authorize]
    public class EmployeeController : ApiController
    {
        private EmployeeRepository empRep = EmployeeRepository.Instance;
        
        [AllowAnonymous]
        // GET: api/Employee
        public List<Employee> Get()
        {
            var emps =  empRep.GetAllEmployees();
            return emps;
        }

        [AllowAnonymous]
        // GET: api/Employee/5
        public Employee Get(int id)
        {
            var emp = empRep.GetEmployee(id);
            return emp;
        }

        [AllowAnonymous]
        [HttpPost]
        //[ResponseType(typeof(int))]
        // POST: api/Employee
        public IHttpActionResult /*void*/ Post([FromBody]Employee value)
        {
            //return 0;
            Employee emp =  empRep.AddNewEmployee(value);
            return Ok<Employee>(emp);
        }

        [AllowAnonymous]
        [HttpPut]
        // PUT: api/Employee/5
        public IHttpActionResult Put(int id, [FromBody]Employee value)
        {
            Employee emp = empRep.ModifyEmployee(value);
            if (emp == null)
            {
                return NotFound();
            }
            else return Ok<Employee>(value);
        }

        [AllowAnonymous]
        [HttpDelete]
        // DELETE: api/Employee/5
        public IHttpActionResult Delete(int id)
        {
            List<Employee> emp = empRep.DeleteEmployee(id);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                return Ok<List<Employee>>(emp);
            }
        }
    }
}
