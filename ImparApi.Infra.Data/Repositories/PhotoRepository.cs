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
    public class PhotoRepository : IPhotoRepository
    {
        private readonly DataContext _dataContext;
        public PhotoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Photo> AddPhoto(Photo newPhoto)
        {
            var result = await _dataContext.Photos.AddAsync(newPhoto);
            return result.Entity;
        }

        public Task<List<Photo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Photo> GetById(int id)
        {
            var result = await _dataContext.Photos.FirstOrDefaultAsync(p => p.Id == id);
            if (result == null)
            {
                throw new Exception("No photo found!");
            }
            return result;
        }
    }
}
