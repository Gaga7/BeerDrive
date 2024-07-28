using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Commons;
using BeerDrive.DAL.Context;
using BeerDrive.DAL.Exceptions;
using BeerDrive.DAL.Implementations;
using BeerDrive.DAL.Implementations.Services;
using BeerDrive.DTOs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class TransactionDetailPresenter
    {
        private readonly Mapper mapper;
        public TransactionDetailPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetTransactionDetailDto>> GetAsync(Expression<Func<BD_TransactionDetails, bool>> predicate)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.TransactionDetailRepository.ReadAsync(predicate);

                return mapper.Map<List<GetTransactionDetailDto>>(entities);

                //var result = from n in entities
                //             let p = n.BD_Products
                //             select new GetTransactionDetailDto
                //             {
                //                 Id = n.Id,
                //                 TransactionId = n.TransactionId,
                //                 ProductId = n.ProductId,
                //                 ProductName = p.Name,
                //                 Quantity = n.Quantity,
                //                 TotalPrice = n.TotalPrice,
                //                 UnitPrice = n.UnitPrice,
                //                 DateCreated = n.DateCreated
                //             };

                //return result.ToList();
            }
        }

        public async Task<List<GetTransactionDetailDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.TransactionDetailRepository.ReadAsync();

                return mapper.Map<List<GetTransactionDetailDto>>(entities);

                //var result = from n in entities
                //             let p = n.BD_Products
                //             let t = n.BD_Transactions
                //             select new GetTransactionDetailDto
                //             {
                //                 Id = n.Id,
                //                 TransactionId = n.TransactionId,
                //                 ProductId = n.ProductId,
                //                 ProductName = p.Name,
                //                 Quantity = n.Quantity,
                //                 TotalPrice = n.TotalPrice,
                //                 UnitPrice = n.UnitPrice,
                //                 DateCreated = t.DateCreated //Todo დასაზუსტებელია რომელი თარიღით შეივსოს
                //             };

                //return result.ToList();
            }
        }

        public async Task<GetTransactionDetailDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.TransactionDetailRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return mapper.Map<GetTransactionDetailDto>(entity);

                //var product = transactionDetail.BD_Products;

                //return new GetTransactionDetailDto
                //{
                //    Id = transactionDetail.Id,
                //    TransactionId = transactionDetail.TransactionId,
                //    ProductId = transactionDetail.ProductId,
                //    ProductName = product.Name,
                //    Quantity = transactionDetail.Quantity,
                //    TotalPrice = transactionDetail.TotalPrice,
                //    UnitPrice = transactionDetail.UnitPrice,
                //    Code = transactionDetail.Code,
                //    DateCreated = transactionDetail.DateCreated
                //};
            }
        }

        public async Task CreateAsync(SetTransactionDetailDto model)
        {
            if (model.TransactionId == null)
                ValidationFault.Throw("ტრანზაქციის იდენტიფიკატორი ცარიელია");

            if (model.ProductId == null)
                ValidationFault.Throw("პროდუქტის იდენტიფიკატორი ცარიელია");

            if (model.Quantity == null)
                ValidationFault.Throw("რაოდენობა ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var product = await unitOfWork.ProductRepository.ReadAsync(model.ProductId.Value);

                if (!product.DisableCheckInStock)
                {
                    if (product.UnitInStock - model.Quantity.Value < 0)
                        ValidationFault.Throw($"პროდუქტი - {product.Name}, არასაკმარისი რაოდენობა საწყობში ({product.UnitInStock} {product.BD_MeasureUnitTypes.Name})");
                }

                //var unitPrice = product.UnitPrice;

                if (product.SetPriceDuringSell)
                {
                    if (model.UnitPrice.GetValueOrDefault() == 0)
                        ValidationFault.Throw("ერთეულის ფასი ცარიელია");

                    //unitPrice = model.UnitPrice.Value;
                }
                else
                    model.UnitPrice = product.UnitPrice;

                var entity = new BD_TransactionDetails
                {
                    Id = Guid.NewGuid(),
                    //TransactionId = model.TransactionId.Value,
                    //ProductId = model.ProductId.Value,
                    //Quantity = model.Quantity.Value,
                    ////UnitPrice = product.UnitPrice,
                    ////TotalPrice = model.Quantity.Value * product.UnitPrice
                    ////UnitPrice = unitPrice,
                    ////TotalPrice = model.Quantity.Value * unitPrice
                    //UnitPrice = model.UnitPrice.Value,
                    //TotalPrice = model.Quantity.Value * model.UnitPrice.Value
                };

                mapper.Map(model, entity);

                await unitOfWork.TransactionDetailRepository.CreateAsync(entity);
                await unitOfWork.SaveAsync();
            }
        }

        public async Task UpdateQuantityAsync(Guid? id, decimal? quantity)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            if (quantity.GetValueOrDefault() == 0)
                ValidationFault.Throw("რაოდენობა ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.TransactionDetailRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                var product = entity.BD_Products;

                if (!product.DisableCheckInStock)
                {
                    if (product.UnitInStock - quantity.Value < 0)
                        ValidationFault.Throw($"პროდუქტი - {product.Name}, არასაკმარისი რაოდენობა საწყობში ({product.UnitInStock} {product.BD_MeasureUnitTypes.Name})");
                }
                entity.Quantity = quantity.Value;
                entity.TotalPrice = quantity.Value * entity.UnitPrice;

                await unitOfWork.TransactionDetailRepository.UpdateAsync(id.Value, entity);

                await unitOfWork.SaveAsync();
            }
        }

        public async Task DeleteAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                if (!await unitOfWork.TransactionDetailRepository.CheckAsync(c => c.Id == id.Value))
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                await unitOfWork.TransactionDetailRepository.DeleteAsync(id.Value);

                await unitOfWork.SaveAsync();
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.TransactionDetailRepository.CheckAsync(c => c.Id == id);
            }
        }

        public async Task SendCodeToEmail(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            var mailTo = ConfigurationManager.AppSettings["EmailTo"];

            if (string.IsNullOrEmpty(mailTo))
                ValidationFault.Throw("მიმღების e-mail ვერ მოიძებნა");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.TransactionDetailRepository.ReadAsync(id.Value);
                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                var product = entity.BD_Products;
                if (product == null)
                    ValidationFault.Throw("პროდუქტი ვერ მოიძებნა");

                var code = RandomCodeGenerator.GetNumber(4);

                if (string.IsNullOrEmpty(code))
                    ValidationFault.Throw("ერთჯერადი კოდის დაგენერირება ვერ განხორციელდა");

                var message = $"<p>პროდუქტი: {product.Name}</p> <p>რაოდენობა: {entity.Quantity}</p> <p>კოდი: <strong>{code}</strong></p>";

                if (!EmailService.Send(mailTo, message))
                    ValidationFault.Throw("ერთჯერადი კოდის გაგზავნა ვერ განხორციალდა");

                entity.Code = code;

                await unitOfWork.TransactionDetailRepository.UpdateAsync(entity.Id, entity);
                await unitOfWork.SaveAsync();
            }
        }
    }
}
