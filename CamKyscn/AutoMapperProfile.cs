using AutoMapper;
using CamKyscn.Dtos;
using CamKyscn.Entities;

namespace CamKyscn
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Banda, GetBandaDTO>();
        }
        
    }
}