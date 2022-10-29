using ImparApi.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.Interfaces.Repositories
{
    public interface IPhotoRepository
    {
        Task<List<Photo>> GetAll();
        Task<Photo> GetById(int id);
        Task<Photo> AddPhoto(Photo newPhoto);
    }
}
