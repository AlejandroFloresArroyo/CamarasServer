using AutoMapper;
using CamKyscn.Dtos;
using CamKyscn.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamKyscn.Services.BandaService
{
	public class BandaService : IBandaService
	{
        private readonly IMapper _mapper;

        public BandaService(IMapper	 mapper)
		{
			this._mapper = mapper;
		}
		public async Task<ServiceResponse<AddBandaDTO>> AddBanda(AddBandaDTO banda)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<List<GetBandaDTO>>> GetAllBandas()
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<GetBandaDTO>> GetBandaById(int id)
		{
			Banda bandaGen = new Banda { Codigo = "abc", Id = id };
			ServiceResponse<GetBandaDTO> serviceResponse = new ServiceResponse<GetBandaDTO>();
			serviceResponse.Data = _mapper.Map<GetBandaDTO>(bandaGen);
			return serviceResponse;
		}
	}
}
