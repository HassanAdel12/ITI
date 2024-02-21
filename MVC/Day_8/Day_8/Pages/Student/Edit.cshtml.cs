using Day_8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Day_8.Pages.Student
{
    public class EditModel : PageModel
    {

        SchoolDbContext context;

        [BindProperty]
        public Models.Student Student { get; set; }

        public SelectList Cities { get; set; }

        public EditModel([FromServices] SchoolDbContext _context)
        {
            context = _context;
        }


        public IActionResult OnGet(int? id)
        {
            Student = context.Students.Find(id);
            if (Student == null)
            {
                return BadRequest();
            }
            Cities = new SelectList(context.Cities.ToList(), "Id", "Name", Student.CityId);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Entry(Student).State = EntityState.Modified;
                    context.SaveChanges();
                    HttpContext.Session.SetString("StudentName", Student.FullName);
                    return RedirectToPage("Index");
                }
                catch (Exception ex)
                {
                    Cities = new SelectList(context.Cities.ToList(), "Id", "Name", Student.CityId);
                    return Page();
                }

            }

            Cities = new SelectList(context.Cities.ToList(), "Id", "Name", Student.CityId);
            return Page();
        }
    }
}
