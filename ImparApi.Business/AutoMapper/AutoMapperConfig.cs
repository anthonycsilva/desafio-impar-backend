using AutoMapper;
using ImparApi.Business.Entities;
using ImparApi.Business.ViewModels.Requests;
using ImparApi.Business.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CarRequest, Car>();
            CreateMap<Car, CarResponse>();
            CreateMap<PhotoRequest, Photo>();
            CreateMap<Photo, PhotoResponse>();
        }
    }
}
