using CamKyscn.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamKyscn.Services.BandaService
{
	public class BandaService : IBandaService
	{
		public async Task<ServiceResponse<Banda>> AddBanda(Banda banda)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<List<Banda>>> GetAllBandas()
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<Banda>> GetBandaById(int id)
		{
			ServiceResponse<Banda> serviceResponse = new ServiceResponse<Banda>();
			serviceResponse.Data = new Banda { Codigo = "abc", Id = 1 };
			return serviceResponse;
		}
	}
}
