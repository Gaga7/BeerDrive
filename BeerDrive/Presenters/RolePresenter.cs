using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Context;
using BeerDrive.DAL.Exceptions;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class RolePresenter
    {
        private readonly Mapper mapper;

        public RolePresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetRoleDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.RoleRepository.ReadAsync();

                return mapper.Map<List<GetRoleDto>>(entities);
            }
        }

        public async Task<GetRoleDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.RoleRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return mapper.Map<GetRoleDto>(entity);
            }
        }

        public async Task CreateAsync(SetRoleDto model)
        {
            if (string.IsNullOrEmpty(model.Name))
                ValidationFault.Throw("დასახელება ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = new BD_Roles
                {
                    Id = Guid.NewGuid()
                };

                mapper.Map(model, entity);

                await unitOfWork.RoleRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateAsync(Guid? id, SetRoleDto model)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            if (string.IsNullOrEmpty(model.Name))
                ValidationFault.Throw("დასახელება ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.RoleRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                mapper.Map(model, entity);

                await unitOfWork.RoleRepository.UpdateAsync(id.Value, entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.RoleRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                await unitOfWork.RoleRepository.DeleteAsync(id.Value);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.RoleRepository.CheckAsync(c => c.Id == id);
            }
        }
    }
}
