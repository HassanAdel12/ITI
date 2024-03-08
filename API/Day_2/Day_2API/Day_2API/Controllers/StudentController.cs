using Day_2API.DTO;
using Day_2API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        SchoolDBContext context;

        public StudentController(SchoolDBContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<GetStudent> studentsList = new List<GetStudent>();
            foreach (Student s in context.Students.ToList())
            {
                GetStudent getStudent = new GetStudent();
                getStudent.Id = s.Id;
                getStudent.FullName = s.FullName;
                getStudent.Graduated = s.Graduated;
                getStudent.Gpa = s.Gpa;
                getStudent.CityId = s.CityId;
                studentsList.Add(getStudent);
            }
            return Ok(studentsList);
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
                GetStudent getStudent = new GetStudent();
                getStudent.Id = student.Id;
                getStudent.FullName = student.FullName;
                getStudent.Graduated = student.Graduated;
                getStudent.Gpa = student.Gpa;
                getStudent.CityId = student.CityId;

                return Ok(getStudent);
            }
        }


        [HttpPost]
        public IActionResult Add(GetStudent getStudent)
        {

            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    Id = getStudent.Id,
                    FullName = getStudent.FullName,
                    Graduated = getStudent.Graduated,
                    Gpa = getStudent.Gpa,
                    CityId = getStudent.CityId

                };
                context.Students.Add(student);
                context.SaveChanges();

                string URL = Url.Action(nameof(GetOneByID), new { ID = getStudent.Id });

                return Created(URL, getStudent );
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("{ID:int}")]
        public IActionResult Update(GetStudent getStudent, int ID)
        {

            if (ModelState.IsValid)
            {
                Student oldStudent = context.Students.Find(ID);
                if (oldStudent != null)
                {
                    oldStudent.FullName = getStudent.FullName;
                    oldStudent.Graduated = getStudent.Graduated;
                    oldStudent.Gpa = getStudent.Gpa;
                    oldStudent.CityId = getStudent.CityId;

                    context.SaveChanges();

                    return Ok();
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

                return Ok();
            }
            else
            {
                return NotFound();
            }


        }

    }
}
