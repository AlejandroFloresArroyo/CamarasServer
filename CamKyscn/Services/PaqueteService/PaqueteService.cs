using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CamKyscn.Context;
using CamKyscn.Dtos.Paquete;
using CamKyscn.Entities;

namespace CamKyscn.Services.PaqueteService
{
    public class PaqueteService : IPaqueteService
    {

        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        public PaqueteService(IMapper mapper, ApplicationDbContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }
        public async Task<ServiceResponse<GetPaqueteDTO>> AddPaquete(AddPaqueteDTO paqueteDto)
        {
            Paquete paquete = _mapper.Map<Paquete>(paqueteDto);
            _context.Paquetes.Add(paquete);
            await _context.SaveChangesAsync();
            ServiceResponse<GetPaqueteDTO> serviceResponse = new ServiceResponse<GetPaqueteDTO>();
            serviceResponse.Data = _mapper.Map<GetPaqueteDTO>(paquete);
            serviceResponse.Message = "Paquete agregado correctamente";
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPaqueteDTO>> GetPaqueteById(int id)
        {
            Paquete paquete =  _context.Paquetes.FirstOrDefault(x => x.Id == id);
            ServiceResponse<GetPaqueteDTO> serviceResponse = new ServiceResponse<GetPaqueteDTO>();
            serviceResponse.Data = _mapper.Map<GetPaqueteDTO>(paquete);
            return serviceResponse;
        }
    }
}