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
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
    
        [HttpGet()]
        public async Task<IActionResult>  GetAll()
        {
            var data = await _userService.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetId(int id)
        {
            var data = await _userService.Get(id);
            return Ok(data);
        }

        [HttpGet("{IDEXITS}")]
        public async Task<IActionResult> Exits(int IDEXITS)
        {
            var data = await _userService.Exits(IDEXITS);
            return Ok(data);
        }



        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserModel data)
        {
            var dataEntity = await _userService.Add(UserMapper.Map(data));
            return Ok(dataEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UserModel data)
        {
            var dataUpdate = await _userService.Update(UserMapper.Map(data));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.Delete(id);
            return Ok();
        }

    }
}
