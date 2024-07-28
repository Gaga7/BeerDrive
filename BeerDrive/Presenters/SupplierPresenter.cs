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
    public class SupplierPresenter
    {
        private readonly Mapper mapper;

        public SupplierPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetSupplierDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.SupplierRepository.ReadAsync();

                return mapper.Map<List<GetSupplierDto>>(entities);
            }
        }

        public async Task<GetSupplierWithContractDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var supplier = await unitOfWork.SupplierRepository.ReadAsync(id.Value);

                if (supplier == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                var supplierContact = supplier.BD_SupplierContacts;

                if (supplierContact == null)
                    ValidationFault.Throw("ჩანაწერი (კონტაქტი) ვერ მოიძებნა");

                var model = mapper.Map<GetSupplierWithContractDto>(supplier);
                mapper.Map(supplierContact, model);

                return model;
            }
        }

        public async Task CreateAsync(SetSupplierDto model)
        {
            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                var supplierContact = new BD_SupplierContacts
                {
                    Id = Guid.NewGuid()
                };

                mapper.Map(model, supplierContact);

                var entity = new BD_Suppliers
                {
                    Id = Guid.NewGuid(),
                    ContactId = supplierContact.Id
                };

                mapper.Map(model, entity);

                await unitOfWork.SupplierContactRepository.CreateAsync(supplierContact);
                await unitOfWork.SupplierRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateAsync(Guid? id, SetSupplierDto model)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.SupplierRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                var supplierContact = entity.BD_SupplierContacts;

                if (supplierContact == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                mapper.Map(model, entity);
                mapper.Map(model, supplierContact);

                await unitOfWork.SupplierRepository.UpdateAsync(id.Value, entity);
                await unitOfWork.SupplierContactRepository.UpdateAsync(supplierContact.Id, supplierContact);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.SupplierRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                await unitOfWork.SupplierRepository.DeleteAsync(id.Value);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.SupplierRepository.CheckAsync(c => c.Id == id);
            }
        }

        private void Validate(SetSupplierDto model)
        {
            if (string.IsNullOrEmpty(model.Name))
                ValidationFault.Throw("დასახელება ცარიელია");

            if (string.IsNullOrEmpty(model.FirstName))
                ValidationFault.Throw("სახელი ცარიელია");

            if (string.IsNullOrEmpty(model.LastName))
                ValidationFault.Throw("გვარი ცარიელია");

            if (model.MobileIndexId == null)
                ValidationFault.Throw("მობილური ცარიელია");

            if (string.IsNullOrEmpty(model.Mobile) || model.Mobile.ToString() == "__-__-__")
                ValidationFault.Throw("მობილური ცარიელია");

            if (model.Mobile.Any(a => a.ToString() == "_"))
                ValidationFault.Throw("არასწორი მობილური");
        }
    }
}
