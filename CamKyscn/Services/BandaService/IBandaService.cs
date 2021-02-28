using CamKyscn.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CamKyscn.Services.BandaService
{
	public interface IBandaService
	{
		Task<ServiceResponse<List<Banda>>> GetAllBandas();
		Task<ServiceResponse<Banda>> GetBandaById(int id);
		Task<ServiceResponse<Banda>> AddBanda(Banda banda);
	}
}
