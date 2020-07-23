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
   public class ServicesService : IServicesService
    {
                                                           
        private readonly IServiceRepository _serviceRepository;

        public ServicesService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }


        public async Task<IEnumerable<Service>> GetAll()
        {
            var dataEntity = await _serviceRepository.GetAll();
            return dataEntity.Select(ServiceMapper.Map);
        }

        public async Task<Service> Get(int id)
        {
            var data = await _serviceRepository.Get(id);            
            return ServiceMapper.Map(data);
        }

        public async Task<Service> Add(Service service)
        {
            var data = await _serviceRepository.Add(ServiceMapper.Map(service));
            return service;
        }

        public async Task<Service> Update(Service service)
        {
            var data = await _serviceRepository.Update(ServiceMapper.Map(service));
            return service;
        }

        public async Task Delete (int id)
        {
           await _serviceRepository.DeleteAsync(id);
        }

        public async Task<bool> Exits(int id)
        {
            var data = await _serviceRepository.Exist(id);
            return data;
        }
    }
}
