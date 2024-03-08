using Day_2MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_2MVC.Controllers
{
    public class StudentController : Controller
    {
        HttpClient client = new HttpClient();

        string EndPointStudent = "http://localhost:32620/api/Student";
        //string EndPointCity = "http://localhost:32620/api/City";

        public async Task<IActionResult> Index()
        {
            List<GetStudent> Students = await client.GetFromJsonAsync<List<GetStudent>>(EndPointStudent);
            return View(Students);
        }


        public async Task<IActionResult> Create()
        {

            return View(new GetStudent());

        }


        [HttpPost]
        public async Task<IActionResult> Create(GetStudent getStudent)
        {

            HttpResponseMessage Response = await client.PostAsJsonAsync<GetStudent>(EndPointStudent, getStudent);

            if (Response.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");

            }
            else
            {
                return View(getStudent);
            }


        }


        public async Task<IActionResult> Edit(int id)
        {

            GetStudent student = await client.GetFromJsonAsync<GetStudent>(EndPointStudent + "/" + id);

            return View(student);

        }


        [HttpPost]
        public async Task<IActionResult> Edit(GetStudent getStudent)
        {
            int id = getStudent.Id;
            HttpResponseMessage Response = await client.PutAsJsonAsync(EndPointStudent + "/" + id, getStudent);

            if (Response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            else
            {
                return View(getStudent);
            }

        }



        public async Task<IActionResult> Delete(int id)
        {

            HttpResponseMessage Response = await client.DeleteAsync(EndPointStudent + "/" + id);

            if (Response.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");

            }
            else
            {
                return NotFound();
            }


        }


        public async Task<IActionResult> Details(int id)
        {
            GetStudent Details = await client.GetFromJsonAsync<GetStudent>(EndPointStudent + "/" + id);
            return View(Details);

        }
    }
}
