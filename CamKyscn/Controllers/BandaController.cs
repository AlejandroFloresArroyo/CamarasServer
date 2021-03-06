using CamKyscn.Dtos;
using CamKyscn.Entities;
using CamKyscn.Services.BandaService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamKyscn.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BandaController: ControllerBase
	{
		private readonly IBandaService _bandaService;

		public BandaController(IBandaService bandaService)
		{
			_bandaService = bandaService;
		}

		[HttpGet()]
		public async Task<IActionResult> Get()
		{
			return Ok(await _bandaService.GetAllBandas());
		}

		[HttpGet("{codigo}")]
		public async Task<IActionResult> GetByCodigo(string codigo)
		{
			return Ok(await _bandaService.GetBandaByCodigo(codigo));
		}

		[HttpPost]
		public async Task<IActionResult> AddBanda(AddBandaDTO banda){
			if (!ModelState.IsValid){
				ServiceResponse<GetBandaDTO> serviceResponse = new ServiceResponse<GetBandaDTO>();
				serviceResponse.Data = null;
				serviceResponse.Success = false;
				serviceResponse.Message = "El modelo banda no es valido";
				return BadRequest(serviceResponse);
			}
			return Ok(await _bandaService.AddBanda(banda));
		}
	}
}
