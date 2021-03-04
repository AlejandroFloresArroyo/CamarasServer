using System.Threading.Tasks;
using CamKyscn.Dtos.Paquete;
using CamKyscn.Entities;

namespace CamKyscn.Services.PaqueteService
{
    public class PaqueteService : IPaqueteService
    {
        public Task<ServiceResponse<AddPaqueteDTO>> AddPaquete(AddPaqueteDTO paquete)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetPaqueteDTO>> GetPaqueteById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}