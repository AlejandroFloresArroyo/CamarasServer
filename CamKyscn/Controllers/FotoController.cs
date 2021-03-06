using System.Threading.Tasks;
using CamKyscn.Services.FotoService;
using Microsoft.AspNetCore.Mvc;

namespace CamKyscn.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class FotoController : ControllerBase
    {
        private readonly IFotoService _fotoService;
        public FotoController(IFotoService fotoService)
        {
            this._fotoService =  fotoService;
        }

        //TODO: Generar GetAll
        [HttpGet("{PaqueteID}")]
        public async Task<IActionResult> GetAllByPaquete(long PaqueteID)
        {
            return Ok();
        }

        //TODO: Generar GetAll
        [HttpPost]
        public async Task<IActionResult> Add()
        {
            return Ok();
        }
        
    }
}