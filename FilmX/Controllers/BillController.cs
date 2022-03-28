using FilmX.Data;
using FilmX.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FilmX.Controllers
{
    public class BillController : Controller
    {
        private readonly ILogger<BillController> _logger;
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        public BillController(ILogger<BillController> logger, ApplicationContext context,UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Detail()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            
            return View();
        }
    }
}
