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
   public class RoomService : IRoomService
    {

        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }


        public async Task<IEnumerable<Room>> GetAll()
        {
            var dataEntity = await _roomRepository.GetAll();
            return dataEntity.Select(RoomMapper.Map);
        }

        public async Task<Room> Get(int id)
        {
            var room = await _roomRepository.Get(id);            
            return RoomMapper.Map(room);
        }

        public async Task<Room> Add(Room room)
        {
            var data = await _roomRepository.Add(RoomMapper.Map(room));
            return room;
        }

        public async Task<Room> Update(Room room)
        {
            var data = await _roomRepository.Update( RoomMapper.Map(room));
            return room;
        }

        public async Task Delete (int id)
        {
           await _roomRepository.DeleteAsync(id);
        }


        public async Task<bool> Exits(int id)
        {
           var data =  await _roomRepository.Exist(id);
            return data;
        }
    }
}
