using DotNetCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrud.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly NetCrudContext _context;

        public EmployeeController(NetCrudContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var employees = await _context.Employees.ToListAsync();
            return View();
        }
    }
}
