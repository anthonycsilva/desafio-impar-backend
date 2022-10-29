using AutoMapper;
using ImparApi.Business.Entities;
using ImparApi.Business.Interfaces.Repositories;
using ImparApi.Business.Interfaces.Services;
using ImparApi.Business.ViewModels.Requests;
using ImparApi.Business.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<CarResponse> AddCar(CarRequest viewModel)
        {
            var car = new Car();
            car.Name = viewModel.Name;
            car.PhotoId = viewModel.PhotoId;
            car.Status = viewModel.Status;
            await _carRepository.AddCar(car);
            return _mapper.Map<CarResponse>(car);
        }

        public async Task<List<CarResponse>> GetAll()
        {
            var cars = await _carRepository.GetAll();
            return _mapper.Map<List<CarResponse>>(cars);
        }

    }
}
