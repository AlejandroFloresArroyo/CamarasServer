using System.Threading.Tasks;
using CamKyscn.Dtos.Paquete;
using CamKyscn.Entities;
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
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }
        
        //TODO: Generar GetByID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _paqueteService.GetPaqueteById(id));
        }
       
        //TODO: Generar GetByIDWithFotos
        [HttpGet("fotos/{id}")]
        public async Task<IActionResult> GetByIdWithFotos(int id)
        {
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddPaqueteDTO paqueteDTO){
            if (!ModelState.IsValid)
            {
                ServiceResponse<GetPaqueteDTO> serviceResponse = new ServiceResponse<GetPaqueteDTO>();
				serviceResponse.Data = null;
				serviceResponse.Success = false;
				serviceResponse.Message = "El modelo no es valido";
				return BadRequest(serviceResponse);
            }
            return Ok(await _paqueteService.AddPaquete(paqueteDTO));
        }

        //TODO: Generar Update
        [HttpPut]
        public async Task<IActionResult> Update(){
            return Ok();
        }
    }
}