using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.Mapper;
using Coworking.Api.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coworking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {

        private readonly IOfficeService _officeService;

        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }
      
        [HttpGet()]
        public async Task<IActionResult>  GetAll()
        {
            var data = await _officeService.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetId(int id)
        {
            var data = await _officeService.Get(id);
            return Ok(data);
        }

        [HttpGet("{IDEXITS}")]
        public async Task<IActionResult> Exits(int IDEXITS)
        {
            var data = await _officeService.Exits(IDEXITS);
            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] OfficeModel data)
        {
            var dataEntity = await _officeService.Add(OfficeMapper.Map(data));
            return Ok(dataEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] OfficeModel data)
        {
            var dataUpdate = await _officeService.Update(OfficeMapper.Map(data));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _officeService.Delete(id);
            return Ok();
        }

    }
}
