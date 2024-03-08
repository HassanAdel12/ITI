using Day_1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentDBContext context;

        public StudentController(StudentDBContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(context.Students.ToList());
        }

        [HttpGet("{ID:int}")]
        public IActionResult GetOneByID(int ID)
        {
            Student student = context.Students.Find(ID);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student);
            }
        }

        [HttpGet("{FullName:alpha}")]
        public IActionResult Search(string FullName)
        {
            IEnumerable<Student> students = context.Students.Where(s => s.FullName == FullName);

            if (students == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(students);
            }
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {

            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();

                string URL = Url.Action(nameof (GetOneByID), new { ID = student.Id });

                return Created(URL, new { Message = $"Added {student.FullName}", student });
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpPut]
        public IActionResult Update(Student student, [FromHeader] int ID)
        {

            if (ModelState.IsValid)
            {
                Student Oldstudent = context.Students.Find(ID);
                if (Oldstudent != null)
                {
                    Oldstudent.FullName = student.FullName;
                    Oldstudent.Graduated = student.Graduated;
                    Oldstudent.Gpa = student.Gpa;

                    context.SaveChanges();

                    return Ok(new { Message = $"Update {student.FullName}", student });
                }
                else
                {
                    return NotFound();
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpPatch("{ID:int}")]
        public IActionResult UpdatePatch(int ID,[FromBody]string FullName )
        {

            if (ModelState.IsValid)
            {
                Student Oldstudent = context.Students.Find(ID);
                if (Oldstudent != null)
                {
                    Oldstudent.FullName = FullName;
                    

                    context.SaveChanges();

                    return Ok(new { Message = $"Update {FullName}", Oldstudent });
                }
                else
                {
                    return NotFound();
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpDelete("{ID:int}")]
        public IActionResult Delete(int ID)
        {

            Student student = context.Students.Find(ID);
            if (student != null)
            {
                context.Students.Remove(student);  
                context.SaveChanges();

                return Ok(new { Message = $"Deleted {student.FullName}", ListOfStudents = context.Students.ToList() });
            }
            else
            {
                return NotFound();
            }

        
        }

    }
}
