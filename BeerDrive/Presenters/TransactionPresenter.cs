using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Context;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class TransactionPresenter
    {
        private readonly Mapper mapper;

        public TransactionPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetTransactionDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.TransactionRepository.ReadAsync();

                return mapper.Map<List<GetTransactionDto>>(entities);
            }
        }

        public async Task<List<GetTransactionDto>> GetAsync(Expression<Func<BD_Transactions, bool>> predicate)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.TransactionRepository.ReadAsync(predicate);

                return mapper.Map<List<GetTransactionDto>>(entities);
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.TransactionRepository.CheckAsync(c => c.Id == id);
            }
        }
    }
}
