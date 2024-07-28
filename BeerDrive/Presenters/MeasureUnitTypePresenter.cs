using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Context;
using BeerDrive.DAL.Exceptions;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class MeasureUnitTypePresenter
    {
        private readonly Mapper mapper;

        public MeasureUnitTypePresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetMeasureUnitTypeDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.MeasureUnitTypeRepository.ReadAsync();

                return mapper.Map<List<GetMeasureUnitTypeDto>>(entities);
            }
        }

        public async Task<GetMeasureUnitTypeDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.MeasureUnitTypeRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return mapper.Map<GetMeasureUnitTypeDto>(entity);
            }
        }

        public async Task CreateAsync(SetMeasureUnitTypeDto model)
        {
            if (string.IsNullOrEmpty(model.Name))
                ValidationFault.Throw("დასახელება ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = new BD_MeasureUnitTypes
                {
                    Id = Guid.NewGuid()
                };

                mapper.Map(model, entity);

                await unitOfWork.MeasureUnitTypeRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateAsync(Guid? id, SetMeasureUnitTypeDto model)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            if (string.IsNullOrEmpty(model.Name))
                ValidationFault.Throw("დასახელება ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.MeasureUnitTypeRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                mapper.Map(model, entity);

                await unitOfWork.MeasureUnitTypeRepository.UpdateAsync(id.Value, entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.MeasureUnitTypeRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                await unitOfWork.MeasureUnitTypeRepository.DeleteAsync(id.Value);
                await unitOfWork.SaveAsync();
            }
        }
    }
}
