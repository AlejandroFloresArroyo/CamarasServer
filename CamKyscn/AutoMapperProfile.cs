using AutoMapper;
using CamKyscn.Dtos;
using CamKyscn.Dtos.Paquete;
using CamKyscn.Entities;

namespace CamKyscn
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GetBandaDTO, Banda>();
            CreateMap<Banda, GetBandaDTO>();
            CreateMap<Banda, AddBandaDTO>();
            CreateMap<AddBandaDTO, Banda>();
            
            CreateMap<AddPaqueteDTO, Paquete>();
            CreateMap<Paquete, AddPaqueteDTO>();
            CreateMap<GetPaqueteDTO, Paquete>();
            CreateMap<Paquete, GetPaqueteDTO>();
        }
        
    }
}