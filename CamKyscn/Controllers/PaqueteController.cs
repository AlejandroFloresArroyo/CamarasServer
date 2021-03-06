using System.Threading.Tasks;
using CamKyscn.Services.PaqueteService;
using Microsoft.AspNetCore.Mvc;

namespace CamKyscn.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaqueteController : ControllerBase
    {
        private readonly IPaqueteService _paqueteService;
        public PaqueteController(IPaqueteService paqueteService)
        {
            this._paqueteService = paqueteService;
        }

        //TODO: Generar GetAll
        [HttpGet]
        public async Task<IActionResult> GetAll(long id)
        {
            return Ok();
        }
        
        //TODO: Generar GetByID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok();
        }
       
        //TODO: Generar GetByIDWithFotos
        [HttpGet("fotos/{id}")]
        public async Task<IActionResult> GetByIdWithFotos(long id)
        {
            return Ok();
        }

        //TODO: Generar Post
        [HttpPost]
        public async Task<IActionResult> Add(){
            return Ok();
        }

        //TODO: Generar Update
        [HttpPut]
        public async Task<IActionResult> Update(){
            return Ok();
        }
    }
}