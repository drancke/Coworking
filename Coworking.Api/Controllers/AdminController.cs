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
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;


        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        // GET: api/Admin
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _adminService.GetAll();

            return Ok(data);
        }

        // GET: api/Admin/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _adminService.GetAdmin(id);

            return Ok(data);
        }
        // GET: api/Admin/5
        [HttpGet("{IDExits}")]
        public async Task<IActionResult> Exist(int id)
        {
            var data = await _adminService.Exits(id);

            return Ok(data);
        }

        // POST: api/Admin
        [HttpPost(Name = "AddAdmin")]
        public async Task<IActionResult> Add([FromBody]AdminModel admin)
        {
            var data = await _adminService.AddAdmin((AdminMapper.Map(admin)));
            return Ok(data);
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AdminModel admin)
        {
            var data = await _adminService.UpdateAdmin(AdminMapper.Map(admin));
            return Ok(data);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _adminService.Delete(id);
            return Ok();
        }

    }
}
