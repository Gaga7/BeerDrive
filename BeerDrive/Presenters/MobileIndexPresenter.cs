using AutoMapper;
using BeerDrive.AutoMapper;
using BeerDrive.DAL.Implementations;
using BeerDrive.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeerDrive.Presenters
{
    public class MobileIndexPresenter
    {
        private readonly Mapper mapper;

        public MobileIndexPresenter()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public async Task<List<GetMobileIndexDto>> GetAsync()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var entities = await unitOfWork.MobileIndexRepository.ReadAsync();

                return mapper.Map<List<GetMobileIndexDto>>(entities);
            }
        }
    }
}
