using APIMVCInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIMVCInventory.Controllers
{
    public class EmployeeController : ApiController
    {
        
        public IEnumerable<Employee> GetEmployees()
        {
            using (ApplicationDbContext db=new ApplicationDbContext())
            {
                return db.employees.ToList();
            }
        }
    }
}
