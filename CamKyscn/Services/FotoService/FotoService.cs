using System.Threading.Tasks;
using CamKyscn.Dtos.Foto;
using CamKyscn.Entities;

namespace CamKyscn.Services.FotoService
{
    public class FotoService : IFotoService
    {
        public Task<ServiceResponse<AddFotoDTO>> AddFoto(AddFotoDTO foto)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetFotoDTO>> GetFotoById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}