using System.Threading.Tasks;
using Crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _context;

        public BlogController(BlogContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }


        // CREATE
        public IActionResult create()
        {
            return View();
        }

        // POST: Blogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Store([Bind("email,title,blogText, category")]
            Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}