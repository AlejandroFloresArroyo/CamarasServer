using System.Threading.Tasks;
using CamKyscn.Dtos.Foto;
using CamKyscn.Entities;

namespace CamKyscn.Services.FotoService
{
    public interface IFotoService
    {
         Task<ServiceResponse<GetFotoDTO>> GetFotoById(int id);
         Task<ServiceResponse<AddFotoDTO>> AddFoto(AddFotoDTO foto);
    }
}