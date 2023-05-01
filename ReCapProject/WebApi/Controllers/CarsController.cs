using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;  
        }


        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest();

        }

        [HttpGet("getById")]

        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]

        public void Add(Car car)
        {
            _carService.Add(car);
        }


        [HttpPut("update")]

        public void update(Car car)
        {
            _carService.Update(car);
        }

        [HttpDelete("delete")]

        public void delete(Car car)
        {
            _carService.Delete(car);
        }

        [HttpGet("getCarsByBrandId")]

        public void GetCarsByBrandId(int id)
        {
            _carService.GetCarsByBrandId(id);
        }

    }
}
