using ECommerce.Core.Entities;
using ECommerce.Data;
using ECommerce.WebUI.Models;
using ECommerce.WebUI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ECommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel()
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Products = await _context.Products.Where(p => p.IsActive && p.IsHome).ToListAsync(),
                News = await _context.News.ToListAsync()

            };
            return View(model);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> ContactUs(Contact contact)
        {
            if (ModelState.IsValid)
            {
               try
                {
                    await _context.Contacts.AddAsync(contact);
                    var value=await _context.SaveChangesAsync();
                    if (value > 0)
                    {
                        TempData["Message"] = @"<div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
  <strong>Message Sent Successfully!</strong> 
  <button type=""button"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close""></button>
</div>";
                     // await MailHelper.SendMailAsync(contact);
                       return RedirectToAction("ContactUs");
                    }
                }
                catch(Exception)
                {
                    ModelState.AddModelError("", "Failed!");
                }
            }
             return View(contact);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
