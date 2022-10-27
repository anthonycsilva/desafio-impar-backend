using ImparApi.Business.ViewModels.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ImparApi.Controllers
{
    [ApiController]
    [Route("car")]
    public class CarController : ControllerBase
    {
        public CarController()
        {

        }

        [HttpGet("getCars")]
        public List<CarResponse> GetCars()
        {
            return new List<CarResponse>();
        }
    }
}
