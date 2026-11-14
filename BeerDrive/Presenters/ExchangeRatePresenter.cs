using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Context;
using BeerDrive.DAL.Exceptions;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class ExchangeRatePresenter
    {
        private readonly Mapper mapper;

        public ExchangeRatePresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetExchangeRateDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.ExchangeRateRepository.ReadAsync();

                return mapper.Map<List<GetExchangeRateDto>>(entities);
            }
        }

        public async Task<List<GetExchangeRateDto>> GetAsync(Expression<Func<BD_ExchangeRates, bool>> predicate)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.ExchangeRateRepository.ReadAsync(predicate);

                return mapper.Map<List<GetExchangeRateDto>>(entities);
            }
        }

        public async Task<GetExchangeRateDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.ExchangeRateRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return mapper.Map<GetExchangeRateDto>(entity);
            }
        }

        public async Task CreateAsync(SetExchangeRateDto model)
        {
            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                var exist = await unitOfWork.ExchangeRateRepository.CheckAsync(c => c.ExchangeTypeId == model.ExchangeTypeId);

                if (exist)
                    ValidationFault.Throw("ჩანაწერი მსგავსი ტიპით უკვე დამატებულია");

                var entity = new BD_ExchangeRates
                {
                    Id = Guid.NewGuid()
                };

                mapper.Map(model, entity);

                await unitOfWork.ExchangeRateRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateAsync(Guid? id, SetExchangeRateDto model)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.ExchangeRateRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                var exist = await unitOfWork.ExchangeRateRepository.CheckAsync(c => c.ExchangeTypeId == model.ExchangeTypeId && c.Id != id.Value);

                if (exist)
                    ValidationFault.Throw("ჩანაწერი მსგავსი ტიპით უკვე დამატებულია");

                var entity = new BD_ExchangeRates
                {
                    Id = Guid.NewGuid()
                };

                mapper.Map(model, entity);

                await unitOfWork.ExchangeRateRepository.DeleteAsync(id.Value);
                await unitOfWork.ExchangeRateRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.ExchangeRateRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                await unitOfWork.ExchangeRateRepository.DeleteAsync(id.Value);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.ExchangeRateRepository.CheckAsync(c => c.Id == id);
            }
        }

        private void Validate(SetExchangeRateDto model)
        {
            if (model.ExchangeTypeId == null)
                ValidationFault.Throw("ტიპი ცარიელია");

            if (model.Score.GetValueOrDefault() <= 0)
                ValidationFault.Throw("ქულა მეტი უნდა იყოს 0-ზე");

            if (model.Amount.GetValueOrDefault() <= 0)
                ValidationFault.Throw("თანხა მეტი უნდა იყოს 0-ზე");
        }
    }
}
