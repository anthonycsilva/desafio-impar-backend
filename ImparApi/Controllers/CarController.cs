using ImparApi.Business.Interfaces.Services;
using ImparApi.Business.ViewModels.Requests;
using ImparApi.Business.ViewModels.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImparApi.Controllers
{
    [ApiController]
    [Route("car")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getCars")]
        public async Task<List<CarResponse>> GetCars()
        {
            var carsResponse = await _carService.GetAll();
            return carsResponse;
        }

        [HttpPost("addCar")]
        public async Task<CarResponse> AddCar([FromForm] CarRequest viewModel)
        {
            var response = await _carService.AddCar(viewModel);
            return response;
        }

        [HttpDelete("deleteCar/{carId}")]
        public async Task<ActionResult> DeleteCar(int carId)
        {
            await _carService.RemoveCar(carId);
            return Ok();
        }
    }
}
