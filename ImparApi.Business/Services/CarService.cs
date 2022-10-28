using ImparApi.Business.Interfaces.Services;
using ImparApi.Business.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.Services
{
    public class CarService : ICarService
    {
        public Task<List<CarResponse>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
