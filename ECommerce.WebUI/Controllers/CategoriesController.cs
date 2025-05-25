using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommerce.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var category=await _context.Categories.Include(p=>p.Products).FirstOrDefaultAsync(category=>category.Id == id);
            if (category == null) 
            {
                return NotFound();
            }

            return View(category);
        }
    }
}
