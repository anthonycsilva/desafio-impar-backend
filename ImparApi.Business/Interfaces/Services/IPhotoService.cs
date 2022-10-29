using ImparApi.Business.Entities;
using ImparApi.Business.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.Interfaces.Services
{
    public interface IPhotoService
    {
        Task<List<PhotoResponse>> GetAll();
        Task<PhotoResponse> GetById(int id);
        Task<PhotoResponse> AddPhoto(Photo newPhoto);
    }
}
