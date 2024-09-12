using Employee.Data;
using Employee.Data.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controller
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
        {
        
                private AppDbContext _dbcontext;
                public EmployeeController(AppDbContext dbcontext)
                {
                    _dbcontext = dbcontext;
                }

        [HttpPost]
        [Route("add")]
        public ActionResult<Employees>AddEmployee(Employee employee)
        {
 
                var NewEmployee = new Employees
                {
                    Emp_Id = 0,
                    FDep_Id = employee.Dep_Id,
                    Name = employee.Name,
                    Salary = employee.Salary,
                    BirthDate = employee.BirthDate,
                };

                _dbcontext.Set<Employees>().Add(NewEmployee);
                _dbcontext.SaveChanges();
                return Ok(NewEmployee);
        }


    }
    }
