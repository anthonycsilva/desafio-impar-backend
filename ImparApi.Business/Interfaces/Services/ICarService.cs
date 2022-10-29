using ImparApi.Business.Entities;
using ImparApi.Business.ViewModels.Requests;
using ImparApi.Business.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.Interfaces.Services
{
    public interface ICarService
    {
        Task<List<CarResponse>> GetAll();
        Task<CarResponse>AddCar(CarRequest viewModel);
    }
}
