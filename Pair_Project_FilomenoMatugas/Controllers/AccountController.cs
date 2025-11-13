using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pair_Project_FilomenoMatugas.Data;
using Pair_Project_FilomenoMatugas.Models;
using Pair_Project_FilomenoMatugas.Services;
namespace Pair_Project_FilomenoMatugas.Controllers
{
    public class AccountController : Controller
    {
        private readonly Pair_Project_FilomenoMatugasContext _context;
        public AccountController(Pair_Project_FilomenoMatugasContext context)
        {
            _context = context;
        }
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Username,Password")] User user)
        {
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                var foundUser = await _context.User.FirstOrDefaultAsync(data => data.Username == user.Username); 
                
                string hashedPassword = HashingService.HashData(user.Password);
                if (foundUser != null && foundUser.Password == hashedPassword)
                {
                    return RedirectToAction("Index", "Movies");
                }
                ModelState.AddModelError(string.Empty, "Invalid username or password.");

                return View(user);
            }
            return View(user);
        }
       
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
        [Route("register")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Username,Password")] User user)
        {
            ModelState.Remove("UserId");    
            if (ModelState.IsValid)
            {
                var existingUser = await _context.User.FirstOrDefaultAsync(data => data.Username == user.Username);
                if (existingUser != null)
                {
                 
                    ModelState.AddModelError(string.Empty, "Username already exists.");
                    
                    return View(user);
                }
                string hashedData = HashingService.HashData(user.Password);
                _context.Add(new User
                {
                    UserId = Guid.NewGuid().ToString(),
                    Username = user.Username,
                    Password = hashedData
                });
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "Account");
            }
            return View(user);
        }


    }
}
