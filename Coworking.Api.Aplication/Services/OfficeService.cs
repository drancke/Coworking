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
   public class OfficeService : IOfficeService
    {

        private readonly IOfficeRepository _officeRepository;

        public OfficeService(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }


        public async Task<IEnumerable<Office>> GetAll()
        {
            var dataEntity = await _officeRepository.GetAll();
            return dataEntity.Select(OfficeMapper.Map);
        }

        public async Task<Office> Get(int id)
        {
            var office = await _officeRepository.Get(id);            
            return OfficeMapper.Map(office);
        }

        public async Task<Office> Add(Office office)
        {
            var data = await _officeRepository.Add(OfficeMapper.Map(office));
            return office;
        }

        public async Task<Office> Update(Office office)
        {
            var data = await _officeRepository.Update( OfficeMapper.Map(office));
            return office;
        }

        public async Task Delete (int id)
        {
           await _officeRepository.DeleteAsync(id);
        }

        public async Task<bool> Exits(int id)
        {
           var office =  await _officeRepository.Exist(id);
            return office;
        }
    }
}
