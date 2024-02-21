using Day_8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Day_8.Pages.Student
{
    public class IndexModel : PageModel
    {

        SchoolDbContext context;

        public List<Models.Student> Students { get; set; }

        [BindProperty]
        public string Search { get; set; }

        public IndexModel([FromServices] SchoolDbContext _context)
        {
            context = _context;
        }


        public void OnGet()
        {
            Students = context.Students.Include("City").ToList();
        }

        public IActionResult OnPostDelete(int id)
        {

            Models.Student student = context.Students.Find(id);
            if (student == null)
            {
                return BadRequest();
            }
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToPage("Index");
        }

        public IActionResult OnPostSearch()
        {

            Students = context.Students.Include("City").Where(s => s.FullName.Contains(Search)).ToList();
            return Page();
        }

    }
}
