using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CamKyscn.Context;
using CamKyscn.Dtos;
using CamKyscn.Entities;

namespace CamKyscn.Services.BandaService
{
	public class BandaService : IBandaService
	{
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public BandaService(IMapper	mapper, ApplicationDbContext context)
		{
			this._mapper = mapper;
			this._context = context;
		}
		public async Task<ServiceResponse<GetBandaDTO>> AddBanda(AddBandaDTO bandaDto)
		{
			Banda banda = _mapper.Map<Banda>(bandaDto);
			_context.Bandas.Add(banda);
			await _context.SaveChangesAsync();
			ServiceResponse<GetBandaDTO> serviceResponse = new ServiceResponse<GetBandaDTO>();
			serviceResponse.Message = "Se ha añadido la banda";
			serviceResponse.Data = _mapper.Map<GetBandaDTO>(banda);
			return serviceResponse;
		}

		public async Task<ServiceResponse<List<GetBandaDTO>>> GetAllBandas()
		{
			ServiceResponse<List<GetBandaDTO>> serviceResponse = new ServiceResponse<List<GetBandaDTO>>();
			serviceResponse.Data = (_context.Bandas.Select(x => _mapper.Map<GetBandaDTO>(x))).ToList();
			return serviceResponse;
		}

		public async Task<ServiceResponse<GetBandaDTO>> GetBandaByCodigo(string codigo)
		{
			Banda banda = _context.Bandas.FirstOrDefault(x => x.Codigo == codigo);
			ServiceResponse<GetBandaDTO> serviceResponse = new ServiceResponse<GetBandaDTO>();
			serviceResponse.Data = _mapper.Map<GetBandaDTO>(banda);
			return serviceResponse;
		}
	}
}
