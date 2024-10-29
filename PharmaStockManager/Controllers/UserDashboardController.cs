using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmaStockManager.Models;
using System.Security.Claims;
using System.Linq;

[Authorize]
public class UserDashboardController : Controller
{
    private readonly PharmaContext _context;
    public UserDashboardController(PharmaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var model = new
        {
            UserDrugs = _context.Drugs.Where(d => d.UserId == userId).ToList(),
            UserCategories = _context.Categories.Where(c => c.UserId == userId).ToList()
        };
        return View(model);
    }
}