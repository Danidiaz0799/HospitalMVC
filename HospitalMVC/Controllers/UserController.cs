using HospitalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly AuthenticationDbContext _context;

        public UserController(AuthenticationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> UserIndex()
        {
            var users = await _context.Users.ToListAsync();

            return View(users);
        }

    }
}
