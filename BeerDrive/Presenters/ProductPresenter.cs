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
    public class ProductPresenter
    {
        private readonly Mapper mapper;

        public ProductPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetProductDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.ProductRepository.ReadAsync();

                return mapper.Map<List<GetProductDto>>(entities);
            }
        }

        public async Task<List<GetProductDto>> GetAsync(Expression<Func<BD_Products, bool>> predicate)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.ProductRepository.ReadAsync(predicate);

                return mapper.Map<List<GetProductDto>>(entities);
            }
        }

        public async Task<GetProductDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.ProductRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return mapper.Map<GetProductDto>(entity);
            }
        }

        public async Task CreateAsync(SetProductDto model)
        {
            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = new BD_Products
                {
                    Id = Guid.NewGuid()
                };

                mapper.Map(model, entity);

                await unitOfWork.ProductRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateAsync(Guid? id, SetProductDto model)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.ProductRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                mapper.Map(model, entity);

                await unitOfWork.ProductRepository.UpdateAsync(id.Value, entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.ProductRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                await unitOfWork.ProductRepository.DeleteAsync(id.Value);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.ProductRepository.CheckAsync(c => c.Id == id);
            }
        }

        private void Validate(SetProductDto model)
        {
            if (string.IsNullOrEmpty(model.Name))
                ValidationFault.Throw("დასახელება ცარიელია");

            if (string.IsNullOrEmpty(model.Barcode))
                ValidationFault.Throw("ბარკოდი ცარიელია");

            if (model.CategoryId == null)
                ValidationFault.Throw("აირჩიეთ კატეგორია");

            if (model.SupplierId == null)
                ValidationFault.Throw("აირჩიეთ ორგანიზაცია");

            if (model.UnitInStock == null)
                ValidationFault.Throw("რაოდენობა საწყობში ცარიელია");

            if (model.MeasureUnitTypeId == null)
                ValidationFault.Throw("აირჩიეთ ზომის ერთეული");

            if (model.UnitPrice == null)
                ValidationFault.Throw("ერთეულის ფასი ცარიელია");
        }
    }
}
