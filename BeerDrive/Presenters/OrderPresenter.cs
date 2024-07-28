using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Commons;
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
    public class OrderPresenter
    {
        private readonly Mapper mapper;

        public OrderPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetOrderDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.OrderRepository.ReadAsync();

                return mapper.Map<List<GetOrderDto>>(entities);
            }
        }

        public async Task CreateAsync(SetOrderDto model)
        {
            Validate(model);

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = new BD_Orders
                {
                    Id = Guid.NewGuid(),
                    OrderNumber = await GenerateOrderNumber()
                };

                mapper.Map(model, entity);

                await unitOfWork.OrderRepository.CreateAsync(entity);

                foreach (var item in entity.BD_OrderDetails)
                {
                    //var orderDetail = new BD_OrderDetails
                    //{
                    //    Id = Guid.NewGuid(),
                    //    OrderId = entity.Id
                    //};

                    //mapper.Map(item, orderDetail);

                    //await unitOfWork.OrderDetailRepository.CreateAsync(orderDetail);

                    item.Id = Guid.NewGuid();

                    var product = await unitOfWork.ProductRepository.ReadAsync(item.ProductId);

                    product.UnitInStock += item.Quantity;

                    await unitOfWork.ProductRepository.UpdateAsync(item.ProductId, product);
                }

                await unitOfWork.SaveAsync();
            }
        }

        public async Task<string> GenerateOrderNumber()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                while (true)
                {
                    var orderNumber = RandomCodeGenerator.GetNumber(10);

                    if (!await unitOfWork.OrderRepository.CheckAsync(a => a.OrderNumber == orderNumber))
                        return orderNumber;
                }
            }
        }

        private void Validate(SetOrderDto model)
        {
            if (model.OrderDate == null)
                ValidationFault.Throw("შეკვეთის თარიღი ცარიელია");

            if (model.UserId == null)
                ValidationFault.Throw("აირჩიეთ მომხმარებელი");

            ValidateOrderDetail(model.OrderDetails);
        }

        private void ValidateOrderDetail(List<SetOrderDetailDto> models)
        {
            if (models == null || !models.Any())
                ValidationFault.Throw("შეკვეთის დეტალები ცარიელია");

            if (models.Any(a => a.ProductId == null))
                ValidationFault.Throw("აირჩიეთ პროდუქტი ყველა ჩანაწერზე");

            if (models.Any(a => a.Quantity.GetValueOrDefault() <= 0))
                ValidationFault.Throw("მიუთითეთ რაოდენობა ყველა ჩანაწერზე");

            if (models.Any(a => a.UnitPrice == null))
                ValidationFault.Throw("მიუთითეთ ფასი ყველა ჩანაწერზე");

            if (models.Any(a => a.TotalPrice == null))
                ValidationFault.Throw("მიუთითეთ თანხა (სულ) ყველა ჩანაწერზე");

            if (models.Any(a => a.Discount == null))
                ValidationFault.Throw("მიუთითეთ ფასდაკლება ყველა ჩანაწერზე");

            if (models.GroupBy(g => g.ProductId.Value).Any(a => a.Count() > 1))
                ValidationFault.Throw("დუბლირებული პროდუქტი");
        }
    }
}
