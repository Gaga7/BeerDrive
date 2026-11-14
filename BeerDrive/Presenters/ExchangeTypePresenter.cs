using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class ExchangeTypePresenter
    {
        private readonly Mapper mapper;

        public ExchangeTypePresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetExchangeTypeDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.ExchangeTypeRepository.ReadAsync();

                return mapper.Map<List<GetExchangeTypeDto>>(entities);
            }
        }
    }
}
