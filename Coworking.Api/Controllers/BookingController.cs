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
    public class BookingController : ControllerBase
    {

        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        /// <summary>
        ///   Get all the booking
        /// </summary>
        /// <returns></returns>
        // GET: api/Booking
        [HttpGet()]
        public async Task<IActionResult>  GetAll()
        {
            var data = await _bookingService.GetAll();
            return Ok(data);
        }
         /// <summary>
         /// Get an booking for Id
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        // GET: api/Booking/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult>  GetId(int id)
        {
            var data =await _bookingService.Get(id);
            return Ok(data);
        }
        /// <summary>
        /// Exist an booking for Id
        /// </summary>
        /// <param name="idExist"></param>
        /// <returns></returns>
        // GET: api/Booking/E
        [HttpGet("{idExist}", Name = "Exist")]
        public async Task<IActionResult> Exits(int idExist)
        {
            var data = await _bookingService.Exits(idExist);
            return Ok(data);
        }

       /// <summary>
       /// Add an booking
       /// </summary>
       /// <param name="data"></param>
       /// <returns></returns>
       [ProducesResponseType(200)]
       [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type = typeof(BookingModel))]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BookingModel data)
        {
            var dataEntity = await _bookingService.Add(BookingMapper.Map(data));
            return Ok(dataEntity);
        }
        /// <summary>
        /// Update an booking
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        // Put: api/Booking/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] BookingModel data)
        {
            var dataUpdate = await _bookingService.Update(BookingMapper.Map(data));
            return Ok();
        }
        /// <summary>
        /// Delete an booking
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/Booking/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookingService.Delete(id);
            return Ok();
        }

    }
}
