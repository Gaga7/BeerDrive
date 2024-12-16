using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Context;
using BeerDrive.DAL.Exceptions;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class CustomerPresenter
    {
        private readonly Mapper mapper;

        public CustomerPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetCustomerDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.CustomerRepository.ReadAsync();

                return mapper.Map<List<GetCustomerDto>>(entities);
            }
        }

        public async Task<List<GetCustomerDto>> GetAsync(Expression<Func<BD_Customers, bool>> predicate)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.CustomerRepository.ReadAsync(predicate);

                return mapper.Map<List<GetCustomerDto>>(entities);
            }
        }

        public async Task<GetCustomerDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.CustomerRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return mapper.Map<GetCustomerDto>(entity);
            }
        }

        public async Task CreateAsync(SetCustomerDto model)
        {
            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                if (await unitOfWork.CustomerRepository.CheckAsync(c => c.Mobile == model.Mobile))
                    ValidationFault.Throw("კლიენტი ამ მობილურის ნომრით უკვე დამატებულია");

                var entity = new BD_Customers
                {
                    Id = Guid.NewGuid()
                };

                mapper.Map(model, entity);

                await unitOfWork.CustomerRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateAsync(Guid? id, SetCustomerDto model)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.CustomerRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                if (await unitOfWork.CustomerRepository.CheckAsync(c => c.Id != entity.Id && c.Mobile == model.Mobile))
                    ValidationFault.Throw("კლიენტი ამ მობილურის ნომრით უკვე დამატებულია");

                mapper.Map(model, entity);

                await unitOfWork.CustomerRepository.UpdateAsync(id.Value, entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.CustomerRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                await unitOfWork.CustomerRepository.DeleteAsync(id.Value);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.CustomerRepository.CheckAsync(c => c.Id == id);
            }
        }

        private void Validate(SetCustomerDto model)
        {
            if (string.IsNullOrEmpty(model.FirstName))
                ValidationFault.Throw("სახელი ცარიელია");

            if (string.IsNullOrEmpty(model.LastName))
                ValidationFault.Throw("გვარი ცარიელია");

            if (string.IsNullOrEmpty(model.Mobile) || model.Mobile.ToString() == "___-__-__-__")
                ValidationFault.Throw("მობილური ცარიელია");

            if (model.Mobile.Any(a => a.ToString() == "_"))
                ValidationFault.Throw("არასწორი მობილური");
        }
    }
}
