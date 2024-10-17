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

        public async Task<GetTransactionDto> GetAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.TransactionRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                return mapper.Map<GetTransactionDto>(entity);
            }
        }

        public async Task<bool> CheckAsync(Guid id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return await unitOfWork.TransactionRepository.CheckAsync(c => c.Id == id);
            }
        }

        public async Task SendCodeToEmailAsync(Guid? id)
        {
            if (id == null)
                ValidationFault.Throw("იდენტიფიკატორი ცარიელია");

            var mailTo = ConfigurationManager.AppSettings["EmailTo"];

            if (string.IsNullOrEmpty(mailTo))
                ValidationFault.Throw("მიმღების e-mail ვერ მოიძებნა");

            using (var unitOfWork = new UnitOfWork())
            {
                var entity = await unitOfWork.TransactionRepository.ReadAsync(id.Value);

                if (entity == null)
                    ValidationFault.Throw("ჩანაწერი ვერ მოიძებნა");

                var code = RandomCodeGenerator.GetNumber(4);

                if (string.IsNullOrEmpty(code))
                    ValidationFault.Throw("ერთჯერადი კოდის დაგენერირება ვერ განხორციელდა");

                var message = $"<p>ტრანზაქციის გაუქმება</p> <p>კოდი: <strong>{code}</strong></p>";

                if (!EmailService.Send(mailTo, message))
                    ValidationFault.Throw("ერთჯერადი კოდის გაგზავნა ვერ განხორციალდა");

                entity.Code = code;

                await unitOfWork.TransactionRepository.UpdateAsync(entity.Id, entity);
                await unitOfWork.SaveAsync();
            }
        }
    }
}
