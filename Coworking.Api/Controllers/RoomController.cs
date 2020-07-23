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
    public class RoomController : ControllerBase
    {

        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
     
        [HttpGet()]
        public async Task<IActionResult>  GetAll()
        {
            var data = await _roomService.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetId(int id)
        {
            var data = await _roomService.Get(id);
            return Ok(data);
        }


        [HttpGet("{IDEXITS}")]
        public async Task<IActionResult> Exits(int IDEXITS)
        {
            var data = await _roomService.Exits(IDEXITS);
            return Ok(data);
        }



        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RoomModel data)
        {
            var dataEntity = await _roomService.Add(RoomMapper.Map(data));
            return Ok(dataEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] RoomModel data)
        {
            var dataUpdate = await _roomService.Update(RoomMapper.Map(data));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _roomService.Delete(id);
            return Ok();
        }

    }
}
