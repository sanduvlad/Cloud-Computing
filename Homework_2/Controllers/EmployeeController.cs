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
    public interface IRepository
    {
        void store();
    }

    public class RepoImp : IRepository
    {
        void IRepository.store()
        {
            
        }
    }
    //[Authorize]
    public class EmployeeController : ApiController
    {
        private EmployeeRepository empRep = EmployeeRepository.Instance;
        private IRepository _repo;

        public EmployeeController()
        {

        }

        public EmployeeController(IRepository repo)
        {
            _repo = repo;
        }


        [Route("swagger/v1")]
        [Route("employee")]
        [AllowAnonymous]

        // route = "swagger / v1 () { return 



        // GET: api/Employee
        public List<Employee> Get()
        {
            var emps =  empRep.GetAllEmployees();
            return emps;
        }

        [AllowAnonymous]
        // GET: api/Employee/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                var emp = empRep.GetEmployee(id);
                return Ok<Employee>(emp);
            }
            catch
            {
                return NotFound();
            }
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
