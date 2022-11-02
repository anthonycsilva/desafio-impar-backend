using ImparApi.Business.Entities;
using ImparApi.Business.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Infra.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _dataContext;

        public CarRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Car> AddCar(Car newCar)
        {
            _dataContext.Cars.Add(newCar);
            await _dataContext.SaveChangesAsync();
            return newCar;
        }

        public async Task<Car> AlterCar(Car entity)
        {
            var car = await _dataContext.Cars
            .Where(x => x.Id == entity.Id)
            .FirstOrDefaultAsync();

            Alter(entity, car);

            _dataContext.Cars.Update(car);
            await _dataContext.SaveChangesAsync();
            return car;
        }

        private static void Alter(Car entity, Car car)
        {
            car.Name = entity.Name;
            car.Status = entity.Status;
            car.Photo = entity.Photo;
        }

        public async Task<List<Car>> GetAll()
        {
            var cars = await _dataContext.Cars
                .Include(x => x.Photo)
                .ToListAsync();
            return cars;
        }

        public async Task RemoveCar(int carId)
        {
            var car = await _dataContext.Cars
            .Where(x => x.Id == carId)
            .Include(x => x.Photo)
            .SingleAsync();
            if (car is null)
                throw new Exception("Carro nao foi encontrado para ser deletado");
            _dataContext.Cars.Remove(car);
            _dataContext.Photos.Remove(car.Photo);
            await _dataContext.SaveChangesAsync();

        }
    }
}
