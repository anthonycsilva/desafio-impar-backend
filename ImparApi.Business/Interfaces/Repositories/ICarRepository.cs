using ImparApi.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.Interfaces.Repositories
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAll();
        Task<Car> AddCar(Car newCar);
        Task<Car> AlterCar(Car entity);
        Task RemoveCar(int carId);
    }
}
