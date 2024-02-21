using Day_8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Day_8.Pages.Student
{
    public class CreateModel : PageModel
    {
        SchoolDbContext context;

        [BindProperty]
        public Models.Student Student { get; set; }

        public SelectList Cities { get; set; }

        [TempData]
        public string StudentName { get; set; }

        public CreateModel([FromServices] SchoolDbContext _context)
        {
            context = _context;
        }


        public void OnGet()
        {
            Cities = new SelectList(context.Cities.ToList(), "Id", "Name");
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Students.Add(Student);
                    context.SaveChanges();
                    StudentName = Student.FullName;
                    return RedirectToPage("Index");
                }
                catch (Exception ex)
                {
                    Cities = new SelectList(context.Cities.ToList(), "Id", "Name");
                    return Page();
                }

            }
            Cities = new SelectList(context.Cities.ToList(), "Id", "Name");
            return Page();
        }
    }
}
