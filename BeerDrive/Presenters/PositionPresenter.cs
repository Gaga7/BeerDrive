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
    public class PositionPresenter
    {
        private readonly Mapper mapper;

        public PositionPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetPositionDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.PositionRepository.ReadAsync();

                return mapper.Map<List<GetPositionDto>>(entities);
            }
        }

        public async Task<GetPositionDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.PositionRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return mapper.Map<GetPositionDto>(entity);
            }
        }

        public async Task CreateAsync(SetPositionDto model)
        {
            if (string.IsNullOrEmpty(model.Name))
                ValidationFault.Throw("დასახელება ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = new BD_Positions
                {
                    Id = Guid.NewGuid()
                };

                mapper.Map(model, entity);

                await unitOfWork.PositionRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateAsync(Guid? id, SetPositionDto model)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            if (string.IsNullOrEmpty(model.Name))
                ValidationFault.Throw("დასახელება ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.PositionRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                mapper.Map(model, entity);

                await unitOfWork.PositionRepository.UpdateAsync(id.Value, entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.PositionRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                await unitOfWork.PositionRepository.DeleteAsync(id.Value);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.PositionRepository.CheckAsync(c => c.Id == id);
            }
        }
    }
}
