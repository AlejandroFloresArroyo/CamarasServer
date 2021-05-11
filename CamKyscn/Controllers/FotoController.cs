using System;
using System.Threading.Tasks;
using CamKyscn.Dtos.Foto;
using CamKyscn.Entities;
using CamKyscn.Services.FotoService;
using Microsoft.AspNetCore.Http;
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
            this._fotoService = fotoService;
        }

        //TODO: Generar GetAll
        [HttpGet("{PaqueteID}")]
        public async Task<IActionResult> GetAllByPaquete(long PaqueteID)
        {
            return Ok("Reached");
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm]AddFotoDTO fotoDTO)
        {
            if (ModelState.IsValid)
            {
                //if (fotoDTO.Foto != null && fotoDTO.Logo != null)

                if (fotoDTO.Foto != null)
                {
                    return Ok(await _fotoService.AddFoto(fotoDTO));
                }
            }

            ServiceResponse<GetFotoDTO> serviceResponse = new ServiceResponse<GetFotoDTO>();
            serviceResponse.Success = false;
            serviceResponse.Data = null;
            serviceResponse.Message = "Bad Request";
            return BadRequest(serviceResponse);
        }

    }
}