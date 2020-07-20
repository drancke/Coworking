using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Api.Application.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coworking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        // GET: api/Booking
        [HttpGet]
        public async Task<IActionResult>  Get()
        {
            var data = await _bookingService.GetAll();
            return Ok(data);
        }

        // GET: api/Booking/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Booking
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Booking/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
