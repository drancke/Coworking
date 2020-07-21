using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Coworking.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.Services
{
   public class BookingService : IBookingService
    {

        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }


        public async Task<IEnumerable<Booking>> GetAll()
        {
            var dataEntity = await _bookingRepository.GetAll();
            return dataEntity.Select(BookingMapper.Map);
        }

        public async Task<Booking> Get(int id)
        {
            var data = await _bookingRepository.Get(id);            
            return BookingMapper.Map(data);
        }

        public async Task<Booking> Add(Booking booking)
        {
            var data = await _bookingRepository.Add(BookingMapper.Map(booking));
            return booking;
        }

        public async Task<Booking> Update(Booking booking)
        {
            var data = await _bookingRepository.Update(booking.Id, BookingMapper.Map(booking));
            return booking;
        }

        public async Task Delete (int id)
        {
           await _bookingRepository.DeleteAsync(id);
        }
        public async Task<bool> Exits(int id)
        {
            var data = await _bookingRepository.Exist(id);
            return data;
        }

    }
}
