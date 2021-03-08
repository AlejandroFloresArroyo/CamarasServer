using System.Threading.Tasks;
using CamKyscn.Dtos.Foto;
using CamKyscn.Entities;

namespace CamKyscn.Services.FotoService
{
    public interface IFotoService
    {
         Task<ServiceResponse<GetFotoDTO>> AddFoto(AddFotoDTO foto);
    }
}