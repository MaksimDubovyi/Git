using Git.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Git.Controllers
{
    public class StudentController : Controller
    {

        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Students != null ?
                        View(await _context.Students.ToListAsync()) :
                        Problem("Entity set 'StudentContext.Students'  is null.");
        }

    }
}
