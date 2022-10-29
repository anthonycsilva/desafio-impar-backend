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

        public async Task<List<Car>> GetAll()
        {
            var cars = await _dataContext.Cars
                .Include(x => x.Photo)
                .ToListAsync();
            return cars;
        }
    }
}
