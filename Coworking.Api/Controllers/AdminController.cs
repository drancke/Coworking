using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coworking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;


        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        // GET: api/Admin
        [HttpGet]
        public  async Task<IActionResult> Get()
        {
            var data = await _adminService.GetAll();

            return Ok(data.Select(AdminMapper.Map));
        }

        // GET: api/Admin/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _adminService.GetAdmin(id);

            return Ok(data);
        }

        // POST: api/Admin
        [HttpPost(Name = "AddAdmin")]
        public async Task<IActionResult> AddAdmin([FromBody]Admin admin)
        {
            var data = await _adminService.AddAdmin((admin));
            return Ok(data);
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAdmin(int id, [FromBody] Admin admin)
        {
            var data = await _adminService.UpdateAdmin(admin);
            return Ok(data);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            await _adminService.Delete(id);
            return Ok();
        }
    }
}
