using CamKyscn.Dtos;
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
			return Ok(await _bandaService.GetBandaById(0));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			return Ok(await _bandaService.GetBandaById(id));
		}

		[HttpPost]
		public async Task<IActionResult> AddBanda(AddBandaDTO banda){
			return Ok(await _bandaService.AddBanda(banda));
		}
	}
}
