using AutoMapper;
using BeerDrive.DAL.Context;
using BeerDrive.DTOs;
using System.Linq;

namespace BeerDrive.AutoMapper
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //Entity To DTO
                cfg.CreateMap<BD_Categories, GetCategoryDto>();
                cfg.CreateMap<BD_MeasureUnitTypes, GetMeasureUnitTypeDto>();
                cfg.CreateMap<BD_MobileIndexes, GetMobileIndexDto>();
                cfg.CreateMap<BD_OrderDetails, GetOrderDetailDto>()
                .ForMember(f => f.ProductName, n => n.MapFrom(m => m.BD_Products.Name))
                .ForMember(f => f.CategoryName, n => n.MapFrom(m => m.BD_Products.BD_Categories.Name))
                .ForMember(f => f.Supplier, n => n.MapFrom(m => m.BD_Products.BD_Suppliers.Name))
                .ForMember(f => f.SupplierContactName, n => n.MapFrom(m => $"{m.BD_Products.BD_Suppliers.BD_SupplierContacts.FirstName} {m.BD_Products.BD_Suppliers.BD_SupplierContacts.LastName}"))
                .ForMember(f => f.SupplierContactMobile, n => n.MapFrom(m => $"{m.BD_Products.BD_Suppliers.BD_SupplierContacts.BD_MobileIndexes.Name} {m.BD_Products.BD_Suppliers.BD_SupplierContacts.Mobile}"))
                .ForMember(f => f.UserFullName, n => n.MapFrom(m => $"{m.BD_Orders.BD_Users.FirstName} {m.BD_Orders.BD_Users.LastName}"))
                .ForMember(f => f.OrderDate, n => n.MapFrom(m => m.BD_Orders.OrderDate));
                cfg.CreateMap<BD_Orders, GetOrderDto>()
                .ForMember(f => f.User, n => n.MapFrom(m => $"{m.BD_Users.FirstName} {m.BD_Users.LastName}"));
                cfg.CreateMap<BD_PayTypes, GetPayTypeDto>();
                cfg.CreateMap<BD_Positions, GetPositionDto>();
                cfg.CreateMap<BD_Products, GetProductDto>()
                .ForMember(f => f.Category, n => n.MapFrom(m => m.BD_Categories.Name))
                .ForMember(f => f.Supplier, n => n.MapFrom(m => m.BD_Suppliers.Name))
                .ForMember(f => f.MeasureUnitType, n => n.MapFrom(m => m.BD_MeasureUnitTypes.Name));
                cfg.CreateMap<BD_Roles, GetRoleDto>();
                cfg.CreateMap<BD_Suppliers, GetSupplierDto>()
                .ForMember(f => f.Contact, n => n.MapFrom(m => $"{m.BD_SupplierContacts.FirstName} {m.BD_SupplierContacts.LastName}"))
                .ForMember(f => f.Mobile, n => n.MapFrom(m => $"{m.BD_SupplierContacts.BD_MobileIndexes.Name} {m.BD_SupplierContacts.Mobile}"));
                cfg.CreateMap<BD_Suppliers, GetSupplierWithContractDto>();
                cfg.CreateMap<BD_SupplierContacts, GetSupplierWithContractDto>()
                .ForMember(f => f.Id, n => n.Ignore())
                .ForMember(f => f.DateCreated, n => n.Ignore());
                cfg.CreateMap<BD_Users, GetUserDto>()
                .ForMember(f => f.Position, n => n.MapFrom(m => m.BD_Positions.Name));
                cfg.CreateMap<BD_Transactions, GetTransactionDto>()
                .ForMember(f => f.PayTypeName, n => n.MapFrom(m => m.BD_PayTypes.Name))
                .ForMember(f => f.TransactionStatusTypeName, n => n.MapFrom(m => m.BD_TransactionStatusTypes.Name))
                .ForMember(f => f.User, n => n.MapFrom(m => $"{m.BD_Users.FirstName} {m.BD_Users.LastName}"));
                cfg.CreateMap<BD_TransactionDetails, GetTransactionDetailDto>()
                .ForMember(f => f.ProductName, n => n.MapFrom(m => m.BD_Products.Name));

                //DTO To Entity
                cfg.CreateMap<SetCategoryDto, BD_Categories>();
                cfg.CreateMap<SetMeasureUnitTypeDto, BD_MeasureUnitTypes>();
                cfg.CreateMap<SetOrderDetailDto, BD_OrderDetails>();
                cfg.CreateMap<SetOrderDto, BD_Orders>()
                .ForMember(f => f.TotalQuantity, n => n.MapFrom(m => m.OrderDetails.Sum(s => s.Quantity)))
                .ForMember(f => f.TotalAmount, n => n.MapFrom(m => m.OrderDetails.Sum(s => s.TotalPrice)));
                cfg.CreateMap<SetPositionDto, BD_Positions>();
                cfg.CreateMap<SetProductDto, BD_Products>();
                cfg.CreateMap<SetRoleDto, BD_Roles>();
                cfg.CreateMap<SetSupplierDto, BD_Suppliers>();
                cfg.CreateMap<SetSupplierDto, BD_SupplierContacts>();
                cfg.CreateMap<SetUserDto, BD_Users>()
                .ForMember(f => f.Password, n => n.Ignore());
                cfg.CreateMap<SetTransactionDetailDto, BD_TransactionDetails>()
                .ForMember(f => f.TotalPrice, n => n.MapFrom(m => m.Quantity.Value * m.UnitPrice.Value));
            });

            return new Mapper(config);
        }
    }
}
