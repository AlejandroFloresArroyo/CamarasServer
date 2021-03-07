using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CamKyscn.Context;
using CamKyscn.Dtos.Paquete;
using CamKyscn.Entities;
using Microsoft.EntityFrameworkCore;

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
            // Paquete paquete = _mapper.Map<Paquete>(paqueteDto);
            Paquete paquete = new Paquete{
                Fecha = paqueteDto.Fecha,
                Comprado = paqueteDto.Comprado,
                Codigo = "123",
            };
            foreach (int id in paqueteDto.Bandas)
            {
                Banda banda = _context.Bandas.FirstOrDefault(x=> x.Id == id);
                paquete.Bandas.Add(banda);
            }
            _context.Paquetes.Add(paquete);
            await _context.SaveChangesAsync();
            ServiceResponse<GetPaqueteDTO> serviceResponse = new ServiceResponse<GetPaqueteDTO>();
            serviceResponse.Data = _mapper.Map<GetPaqueteDTO>(paquete);
            serviceResponse.Message = "Paquete agregado correctamente";
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPaqueteDTO>>> GetAllPaquetes()
        {
            ServiceResponse<List<GetPaqueteDTO>> serviceResponse = new ServiceResponse<List<GetPaqueteDTO>>();
            
			serviceResponse.Data = _mapper.Map<List<GetPaqueteDTO>>(_context.Paquetes.Include(x => x.Bandas).ToList());
			// serviceResponse.Data = (_context.Paquetes.Select(x => _mapper.Map<Paquete>(x))).ToList();
			return serviceResponse;
        }

        public async Task<ServiceResponse<GetPaqueteDTO>> GetPaqueteById(int id)
        {
            Paquete paquete = await _context.Paquetes.Include(x => x.Bandas).SingleAsync(a => a.Id == id);
            ServiceResponse<GetPaqueteDTO> serviceResponse = new ServiceResponse<GetPaqueteDTO>();
            serviceResponse.Data = _mapper.Map<GetPaqueteDTO>(paquete);
            return serviceResponse;
        }
        public async Task<ServiceResponse<GetPaqueteDTO>> GetPaqueteByIdFotos(int id)
        {
            Paquete paquete =  await _context.Paquetes.Include(x => x.Bandas).SingleAsync(a => a.Id == id);
            ServiceResponse<GetPaqueteDTO> serviceResponse = new ServiceResponse<GetPaqueteDTO>();
            serviceResponse.Data = _mapper.Map<GetPaqueteDTO>(paquete);
            return serviceResponse;
        }
    }
}