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
    public class ServiceController : ControllerBase
    {

        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }
     
        [HttpGet()]
        public async Task<IActionResult>  GetAll()
        {
            var data = await _servicesService.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetId(int id)
        {
            var data = await _servicesService.Get(id);
            return Ok(data);
        }

        [HttpGet("{IDEXITS}")]
        public async Task<IActionResult> Exits(int IDEXITS)
        {
            var data = await _servicesService.Exits(IDEXITS);
            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ServiceModel data)
        {
            var dataEntity = await _servicesService.Add(ServiceMapper.Map(data));
            return Ok(dataEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] ServiceModel data)
        {
            var dataUpdate = await _servicesService.Update(ServiceMapper.Map(data));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _servicesService.Delete(id);
            return Ok();
        }

    }
}
