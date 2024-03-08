using Day_2MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_2MVC.Controllers
{
    public class CityController : Controller
    {
        HttpClient client = new HttpClient();

        //string EndPointStudent = "http://localhost:32620/api/Student";
        string EndPointCity = "http://localhost:32620/api/City";

        public async Task<IActionResult> Index()
        {
            List<GetCity> cities = await client.GetFromJsonAsync<List<GetCity>>(EndPointCity);
            return View(cities);
        }

        
        public async Task<IActionResult> Create()
        {

            return View(new GetCity());

        }


        [HttpPost]
        public async Task<IActionResult> Create(GetCity getCity)
        {

            HttpResponseMessage Response = await client.PostAsJsonAsync<GetCity>(EndPointCity, getCity);

            if (Response.IsSuccessStatusCode)
            {
                

                return RedirectToAction("Index");

            }
            else
            {
                return View(getCity);
            }


        }


        public async Task<IActionResult> Edit(int id)
        {

            GetCity city = await client.GetFromJsonAsync<GetCity>(EndPointCity+"/"+id);
            
            return View(city);

        }


        [HttpPost]
        public async Task<IActionResult> Edit(GetCity getCity)
        {
            int id = getCity.Id;

            HttpResponseMessage Response = await client.PutAsJsonAsync(EndPointCity + "/" + id, getCity);

            if (Response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            else
            {
                return View(getCity);
            }

        }



        public async Task<IActionResult> Delete(int id)
        {

            HttpResponseMessage Response = await client.DeleteAsync(EndPointCity + "/" + id);

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
            GetCity Details = await client.GetFromJsonAsync<GetCity>(EndPointCity + "/" + id);
            return View(Details);

        }

    }
}
