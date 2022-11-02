using AutoMapper;
using ImparApi.Business.Entities;
using ImparApi.Business.Helpers;
using ImparApi.Business.Interfaces.Repositories;
using ImparApi.Business.Interfaces.Services;
using ImparApi.Business.ViewModels.Requests;
using ImparApi.Business.ViewModels.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImparApi.Business.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IPhotoRepository _photoRepository;
        private readonly IMapper _mapper;
        public CarService(ICarRepository carRepository, IMapper mapper, IPhotoRepository photoRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _photoRepository = photoRepository;
        }

        public async Task<CarResponse> AddCar(CarRequest viewModel)
        {
            var car = new Car();
            car.Photo = UploadPhoto(viewModel);
            car.Name = viewModel.Name;
            car.Status = viewModel.Status;
            await _carRepository.AddCar(car);
            return _mapper.Map<CarResponse>(car);
        }

        private static Photo UploadPhoto(CarRequest viewModel)
        {
            var photoB64 = FileConverter.ConvertImageFileToBase64(viewModel.Photo);
            var photo = new Photo();
            photo.Base64 = photoB64;
            return photo;
        }

        public async Task<List<CarResponse>> GetAll()
        {
            var cars = await _carRepository.GetAll();
            return _mapper.Map<List<CarResponse>>(cars);
        }

        public async Task RemoveCar(int carId)
        {
            await _carRepository.RemoveCar(carId);
        }

        public async Task<CarResponse> AlterCar(CarRequest viewModel, int carId)
        {
            Car entity = MappingViewModelToEntity(viewModel, carId);
            var result = await _carRepository.AlterCar(entity);

            return _mapper.Map<CarResponse>(result);
        }

        private static Car MappingViewModelToEntity(CarRequest viewModel, int carId)
        {
            var entity = new Car();
            entity.Id = carId;
            entity.Name = viewModel.Name;
            entity.Status = viewModel.Status;
            entity.Photo = UploadPhoto(viewModel);
            return entity;
        }
    }
}
