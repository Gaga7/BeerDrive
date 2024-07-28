using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class PayTypePresenter
    {
        private readonly Mapper mapper;

        public PayTypePresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetPayTypeDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.PayTypeRepository.ReadAsync();

                return mapper.Map<List<GetPayTypeDto>>(entities.OrderBy(o => o.OrderIndex));
            }
        }
    }
}
