using ImparApi.Business.Entities;
using ImparApi.Business.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Infra.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        public Task<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
