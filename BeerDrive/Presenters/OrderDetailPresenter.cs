using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class OrderDetailPresenter
    {
        private readonly Mapper mapper;

        public OrderDetailPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetOrderDetailDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.OrderDetailRepository.ReadAsync();

                return mapper.Map<List<GetOrderDetailDto>>(entities);
            }
        }
    }
}
