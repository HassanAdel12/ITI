using Day_2API.DTO;
using Day_2API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        SchoolDBContext context;

        public CityController(SchoolDBContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<GetCity> cityList = new List<GetCity>();
            foreach (City c  in context.Citys.ToList())
            {
                GetCity getcity = new GetCity();
                getcity.Id = c.Id;
                getcity.Name = c.Name;
                cityList.Add(getcity);
            }
            return Ok(cityList);
        }

        [HttpGet("{ID:int}")]
        public IActionResult GetOneByID(int ID)
        {
            City city = context.Citys.Find(ID);
            if (city == null)
            {
                return NotFound();
            }
            else
            {
                GetCity getcity = new GetCity();
                getcity.Id = city.Id;
                getcity.Name = city.Name;
                
                return Ok(getcity);
            }
        }


        [HttpPost]
        public IActionResult Add(GetCity getCity)
        {

            if (ModelState.IsValid)
            {
                City city = new City()
                {
                    Id = getCity.Id,
                    Name = getCity.Name
                    
                };
                context.Citys.Add(city);
                context.SaveChanges();

                string URL = Url.Action(nameof(GetOneByID), new { ID = getCity.Id });

                return Created(URL, getCity );
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("{ID:int}")]
        public IActionResult Update( GetCity getCity ,int ID)
        {

            if (ModelState.IsValid)
            {
                City Oldcity = context.Citys.Find(ID);
                
                if (Oldcity != null)
                {
                    Oldcity.Name = getCity.Name;
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

            City city = context.Citys.Find(ID);
            if (city != null)
            {
                context.Citys.Remove(city);
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
