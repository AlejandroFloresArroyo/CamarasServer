using System.Collections.Generic;
using System.Threading.Tasks;
using CamKyscn.Dtos.Paquete;
using CamKyscn.Entities;

namespace CamKyscn.Services.PaqueteService
{
    public interface IPaqueteService
    {
        Task<ServiceResponse<List<GetPaqueteDTO>>> GetAllPaquetes();
        Task<ServiceResponse<GetPaqueteDTO>> GetPaqueteById(int id);
        Task<ServiceResponse<GetPaqueteDTO>> AddPaquete(AddPaqueteDTO paquete);

    }
}