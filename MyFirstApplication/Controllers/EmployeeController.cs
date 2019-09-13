using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MyFirstApplication.Controllers
{
    [Route("data/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }

        public ActionResult GetAllEmployees(EmployeeInfo e)
        {
            return Ok(_context.employees.AsQueryable());
        }
    }
}