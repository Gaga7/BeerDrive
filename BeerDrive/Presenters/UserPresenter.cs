using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Context;
using BeerDrive.DAL.Exceptions;
using BeerDrive.DAL.Implementations;
using BeerDrive.DAL.ViewEntities;
using BeerDrive.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class UserPresenter
    {
        private readonly Mapper mapper;

        public UserPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetUserDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.UserRepository.ReadAsync();

                return mapper.Map<List<GetUserDto>>(entities);
            }
        }

        public async Task<List<GetUserDto>> GetAsync(Expression<Func<BD_Users, bool>> predicate)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.UserRepository.ReadAsync(predicate);

                return mapper.Map<List<GetUserDto>>(entities);
            }
        }

        public async Task<GetUserDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.UserRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                var position = entity.BD_Positions;
                var roleIds = entity.BD_UserRoles.Where(r => r.DateDeleted == null).Select(s => s.BD_Roles).Where(r => r.DateDeleted == null).Select(s => s.Id).ToList();

                var model = mapper.Map<GetUserDto>(entity);

                model.RoleIds = roleIds;

                return model;
            }
        }

        public async Task<GetUserDto> LoginAsync(AuthHeader header)
        {
            if (string.IsNullOrEmpty(header.LoginName))
                ValidationFault.Throw("მომხმარებელი ცარიელია");

            if (string.IsNullOrEmpty(header.Password))
                ValidationFault.Throw("პაროლი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.UserRepository.LoginAsync(header.LoginName, header.Password);
                if (entity == null)
                    ValidationFault.Throw("არასწორი მომხმარებელი ან პაროლი");

                var position = entity.BD_Positions;
                var roles = entity.BD_UserRoles.Where(r => r.DateDeleted == null).Select(s => s.BD_Roles).Where(r => r.DateDeleted == null);

                var model = mapper.Map<GetUserDto>(entity);

                model.IsAdmin = roles.Any(a => a.Name == "Admin");
                model.IsOperator = roles.Any(a => a.Name == "Operator");
                model.IsManager = roles.Any(a => a.Name == "Manager");

                return model;
            }
        }

        public async Task CreateAsync(SetUserDto model)
        {
            Validate(model);

            if (string.IsNullOrEmpty(model.Password))
                ValidationFault.Throw("პაროლი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = new BD_Users
                {
                    Id = Guid.NewGuid(),
                    Password = model.Password
                };

                mapper.Map(model, entity);

                await unitOfWork.UserRepository.CreateAsync(entity);

                foreach (var roleId in model.RoleIds)
                {
                    var userRole = new BD_UserRoles
                    {
                        Id = Guid.NewGuid(),
                        UserId = entity.Id,
                        RoleId = roleId
                    };

                    await unitOfWork.UserRoleRepository.CreateAsync(userRole);
                }

                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateAsync(Guid id, SetUserDto model)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.UserRepository.ReadAsync(id);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                mapper.Map(model, entity);

                await unitOfWork.UserRepository.UpdateAsync(id, entity);

                var roleIds = entity.BD_UserRoles.Where(r => r.DateDeleted == null).Select(s => s.BD_Roles).Where(r => r.DateDeleted == null).Select(s => s.Id).ToList();
                var newRoleIds = model.RoleIds.Except(roleIds).ToList();
                var roleIdsToDelete = roleIds.Except(model.RoleIds).ToList();

                foreach (var roleIdToDelete in roleIdsToDelete)
                {
                    var userRoleToDelete = entity.BD_UserRoles.FirstOrDefault(r => r.DateDeleted == null && r.RoleId == roleIdToDelete);

                    if (userRoleToDelete != null)
                        await unitOfWork.UserRoleRepository.DeleteAsync(userRoleToDelete.Id);
                }

                foreach (var newRoleId in newRoleIds)
                {
                    var userRole = new BD_UserRoles
                    {
                        Id = Guid.NewGuid(),
                        UserId = id,
                        RoleId = newRoleId
                    };

                    await unitOfWork.UserRoleRepository.CreateAsync(userRole);
                }

                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.UserRepository.ReadAsync(id);
                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                entity.DateDeleted = DateTime.Now;

                await unitOfWork.UserRepository.UpdateAsync(id, entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.UserRepository.CheckAsync(c => c.Id == id);
            }
        }

        private void Validate(SetUserDto model)
        {
            if (string.IsNullOrEmpty(model.PersonalId))
                ValidationFault.Throw("პირადი ნომერი ცარიელია");

            if (string.IsNullOrEmpty(model.FirstName))
                ValidationFault.Throw("სახელი ცარიელია");

            if (string.IsNullOrEmpty(model.LastName))
                ValidationFault.Throw("გვარი ცარიელია");

            if (string.IsNullOrEmpty(model.LoginName))
                ValidationFault.Throw("მომხმარებელი ცარიელია");

            //if (string.IsNullOrEmpty(model.Password))
            //    ValidationFault.Throw("პაროლი ცარიელია");

            if (model.PositionId == null)
                ValidationFault.Throw("აირჩიეთ პოზიცია");

            if (!model.RoleIds.Any())
                ValidationFault.Throw("აირჩიეთ მინიმუმ ერთი როლი");
        }
    }
}
