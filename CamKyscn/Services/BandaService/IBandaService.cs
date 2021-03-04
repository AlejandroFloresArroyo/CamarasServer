using CamKyscn.Dtos;
using CamKyscn.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CamKyscn.Services.BandaService
{
	public interface IBandaService
	{
		Task<ServiceResponse<List<GetBandaDTO>>> GetAllBandas();
		Task<ServiceResponse<GetBandaDTO>> GetBandaById(int id);
		Task<ServiceResponse<AddBandaDTO>> AddBanda(AddBandaDTO banda);
	}
}
