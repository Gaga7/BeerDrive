using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Commons;
using BeerDrive.DAL.Context;
using BeerDrive.DAL.Enums;
using BeerDrive.DAL.Exceptions;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class TerminalPresenter
    {
        private readonly Mapper mapper;

        public TerminalPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<GetTerminalDto> GetLastActiveAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.TransactionRepository.ReadAsync(r => r.TransactionStatusTypeId == TransactionStatusTypesEnum.WorkingProcess);
                var entity = entities.OrderByDescending(o => o.DateCreated).FirstOrDefault();

                if (entity == null)
                    return null;

                return new GetTerminalDto
                {
                    Transaction = mapper.Map<GetTransactionDto>(entity),
                    TransactionDetails = mapper.Map<List<GetTransactionDetailDto>>(entity.BD_TransactionDetails.Where(r => r.DateDeleted == null))
                };

                //var payType = entity.BD_PayTypes;
                //var transactionStatusType = entity.BD_TransactionStatusTypes;

                //return new GetTerminalDto
                //{
                //    Transaction = new GetTransactionDto
                //    {
                //        Id = entity.Id,
                //        PayTypeId = entity.PayTypeId,
                //        PayTypeName = payType?.Name,
                //        TransactionStatusTypeId = entity.TransactionStatusTypeId,
                //        TransactionStatusTypeName = transactionStatusType.Name,
                //        TransactionNumber = entity.TransactionNumber,
                //        TotalQuantity = entity.TotalQuantity,
                //        TotalAmount = entity.TotalAmount,
                //    },

                //    TransactionDetails = (from td in entity.BD_TransactionDetails
                //                          let p = td.BD_Products
                //                          where td.DateDeleted == null
                //                          select new GetTransactionDetailDto
                //                          {
                //                              Id = td.Id,
                //                              TransactionId = td.TransactionId,
                //                              ProductId = td.ProductId,
                //                              ProductName = p.Name,
                //                              Quantity = td.Quantity,
                //                              UnitPrice = td.UnitPrice,
                //                              TotalPrice = td.TotalPrice,
                //                              DateCreated = td.DateCreated
                //                          }).OrderByDescending(o => o.DateCreated).ToList()
                //};
            }
        }

        public async Task<GetTerminalDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.TransactionRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return new GetTerminalDto
                {
                    Transaction = mapper.Map<GetTransactionDto>(entity),
                    TransactionDetails = mapper.Map<List<GetTransactionDetailDto>>(entity.BD_TransactionDetails.Where(r => r.DateDeleted == null))
                };

                //var payType = entity.BD_PayTypes;
                //var transactionStatusType = entity.BD_TransactionStatusTypes;

                //return new GetTerminalDto
                //{
                //    Transaction = new GetTransactionDto
                //    {
                //        Id = entity.Id,
                //        PayTypeId = entity.PayTypeId,
                //        PayTypeName = payType?.Name,
                //        TransactionStatusTypeId = entity.TransactionStatusTypeId,
                //        TransactionStatusTypeName = transactionStatusType.Name,
                //        TransactionNumber = entity.TransactionNumber,
                //        TotalQuantity = entity.TotalQuantity,
                //        TotalAmount = entity.TotalAmount,
                //    },

                //    TransactionDetails = (from td in entity.BD_TransactionDetails
                //                          let p = td.BD_Products
                //                          where td.DateDeleted == null
                //                          select new GetTransactionDetailDto
                //                          {
                //                              Id = td.Id,
                //                              TransactionId = td.TransactionId,
                //                              ProductId = td.ProductId,
                //                              ProductName = p.Name,
                //                              Quantity = td.Quantity,
                //                              UnitPrice = td.UnitPrice,
                //                              TotalPrice = td.TotalPrice,
                //                              DateCreated = td.DateCreated
                //                          }).OrderByDescending(o => o.DateCreated).ToList()
                //};
            }
        }

        public async Task<Guid> CreateAsync(SetTerminalDto model)
        {
            var transactionDetailModel = model.TransactionDetail;

            if (transactionDetailModel.ProductId == null)
                ValidationFault.Throw("პროდუქტის იდენტიფიკატორი ცარიელია");

            if (transactionDetailModel.Quantity == null)
                ValidationFault.Throw("რაოდენობა ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var product = await unitOfWork.ProductRepository.ReadAsync(transactionDetailModel.ProductId.Value);

                if (product == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                if (!product.DisableCheckInStock)
                {
                    if (product.UnitInStock - transactionDetailModel.Quantity.Value < 0)
                        ValidationFault.Throw($"პროდუქტი - {product.Name}, არასაკმარისი რაოდენობა საწყობში ({product.UnitInStock} {product.BD_MeasureUnitTypes.Name})");
                }

                //var unitPrice = product.UnitPrice;

                if (product.SetPriceDuringSell)
                {
                    if (transactionDetailModel.UnitPrice.GetValueOrDefault() == 0)
                        ValidationFault.Throw("ერთეულის ფასი ცარიელია");

                    //unitPrice = transactionDetailModel.UnitPrice.Value;
                }
                else
                    transactionDetailModel.UnitPrice = product.UnitPrice;

                var transaction = new BD_Transactions
                {
                    Id = Guid.NewGuid(),
                    TransactionStatusTypeId = TransactionStatusTypesEnum.WorkingProcess,
                    TransactionNumber = model.TransactionNumber
                };

                transactionDetailModel.TransactionId = transaction.Id;

                var transactionDetail = new BD_TransactionDetails
                {
                    Id = Guid.NewGuid(),
                    ////TransactionId = transaction.Id,
                    //TransactionId = transactionDetailModel.TransactionId.Value,
                    //ProductId = transactionDetailModel.ProductId.Value,
                    //Quantity = transactionDetailModel.Quantity.Value,
                    ////UnitPrice = product.UnitPrice,
                    ////TotalPrice = transactionDetailModel.Quantity.Value * product.UnitPrice
                    ////UnitPrice = unitPrice,
                    ////TotalPrice = transactionDetailModel.Quantity.Value * unitPrice
                    //UnitPrice = transactionDetailModel.UnitPrice.Value,
                    //TotalPrice = transactionDetailModel.Quantity.Value * transactionDetailModel.UnitPrice.Value
                };

                mapper.Map(transactionDetailModel, transactionDetail);

                await unitOfWork.TransactionRepository.CreateAsync(transaction);
                await unitOfWork.TransactionDetailRepository.CreateAsync(transactionDetail);

                await unitOfWork.SaveAsync();

                return transaction.Id;
            }
        }

        public async Task<string> GenerateTransactionNumber()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                while (true)
                {
                    var transactionNumber = RandomCodeGenerator.GetNumber(10);

                    if (!await unitOfWork.TransactionRepository.CheckAsync(a => a.TransactionNumber == transactionNumber))
                        return transactionNumber;
                }
            }
        }

        public async Task PayAsync(SetPayDto model)
        {
            if (model.Id == null)
                ValidationFault.Throw("ტრანზაქციის იდენტიფიკატორი ცარიელია");

            if (model.PayTypeId == null)
                ValidationFault.Throw("აირჩიეთ გადახდის მეთოდი");

            if (model.PayTypeId == PayTypesEnum.Cash)
            {
                if (model.Cash.GetValueOrDefault() == 0)
                    ValidationFault.Throw("თანხა (მიღებული) ცარიელია");

                if (model.Change.GetValueOrDefault() < 0)
                    ValidationFault.Throw("არასაკმარისი თანხა");
            }

            using (var unitOfWork = new UnitOfWork())
            {
                var transaction = await unitOfWork.TransactionRepository.ReadAsync(model.Id.Value);
                var transactionDetails = transaction.BD_TransactionDetails.Where(r => r.DateDeleted == null);

                foreach (var transactionDetail in transactionDetails)
                {
                    var product = await unitOfWork.ProductRepository.ReadAsync(transactionDetail.ProductId);
                    var unitInStock = product.UnitInStock - transactionDetail.Quantity;

                    if (unitInStock < 0)
                    {
                        if (product.DisableCheckInStock)
                            unitInStock = 0;
                        else
                            ValidationFault.Throw($"პროდუქტი - {product.Name}, არასაკმარისი რაოდენობა საწყობში ({product.UnitInStock} {product.BD_MeasureUnitTypes.Name})");
                    }

                    product.UnitInStock = unitInStock;

                    await unitOfWork.ProductRepository.UpdateAsync(product.Id, product);
                }

                transaction.PayTypeId = model.PayTypeId.Value;
                transaction.Cash = model.Cash;
                transaction.Change = model.Change;
                transaction.TransactionStatusTypeId = TransactionStatusTypesEnum.Completed;
                transaction.TotalQuantity = transactionDetails.Sum(s => s.Quantity);
                transaction.TotalAmount = transactionDetails.Sum(s => s.TotalPrice);

                await unitOfWork.TransactionRepository.UpdateAsync(transaction.Id, transaction);

                await unitOfWork.SaveAsync();
            }
        }
    }
}
