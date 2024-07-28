using BeerDrive.DAL.Context;
using System;
using System.Threading.Tasks;
using BeerDrive.DAL.Implementations.Repositories;
using BeerDrive.DAL.Global;

namespace BeerDrive.DAL.Implementations
{
    public class UnitOfWork : IDisposable
    {
        private readonly BeerDriveContext context;

        private GenericRepository<BD_Categories> categoryRepository;
        private GenericRepository<BD_Products> productRepository;
        private UserRepository userRepository;
        private GenericRepository<BD_Orders> orderRepository;
        private GenericRepository<BD_OrderDetails> orderDetailRepository;
        private GenericRepository<BD_Suppliers> supplierRepository;
        private GenericRepository<BD_SupplierContacts> supplierContactRepository;
        private GenericRepository<BD_MeasureUnitTypes> measureUnitTypeRepository;
        private GenericRepository<BD_PayTypes> payTypeRepository;
        private GenericRepository<BD_Transactions> transactionRepository;
        private GenericRepository<BD_TransactionDetails> transactionDetailRepository;
        private GenericRepository<BD_Roles> roleRepository;
        private GenericRepository<BD_Positions> positionRepository;
        private GenericRepository<BD_UserRoles> userRoleRepository;
        private GenericRepository<BD_MobileIndexes> mobileIndexRepository;

        public GenericRepository<BD_Categories> CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new GenericRepository<BD_Categories>(context);

                return categoryRepository;
            }
        }

        public GenericRepository<BD_Products> ProductRepository
        {
            get
            {
                if (productRepository == null)
                    productRepository = new GenericRepository<BD_Products>(context);

                return productRepository;
            }
        }

        public UserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(context);

                return userRepository;
            }
        }

        public GenericRepository<BD_Orders> OrderRepository
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new GenericRepository<BD_Orders>(context);

                return orderRepository;
            }
        }

        public GenericRepository<BD_OrderDetails> OrderDetailRepository
        {
            get
            {
                if (orderDetailRepository == null)
                    orderDetailRepository = new GenericRepository<BD_OrderDetails>(context);

                return orderDetailRepository;
            }
        }

        public GenericRepository<BD_Suppliers> SupplierRepository
        {
            get
            {
                if (supplierRepository == null)
                    supplierRepository = new GenericRepository<BD_Suppliers>(context);

                return supplierRepository;
            }
        }

        public GenericRepository<BD_MeasureUnitTypes> MeasureUnitTypeRepository
        {
            get
            {
                if (measureUnitTypeRepository == null)
                    measureUnitTypeRepository = new GenericRepository<BD_MeasureUnitTypes>(context);

                return measureUnitTypeRepository;
            }
        }

        public GenericRepository<BD_PayTypes> PayTypeRepository
        {
            get
            {
                if (payTypeRepository == null)
                    payTypeRepository = new GenericRepository<BD_PayTypes>(context);

                return payTypeRepository;
            }
        }

        public GenericRepository<BD_Transactions> TransactionRepository
        {
            get
            {
                if (transactionRepository == null)
                    transactionRepository = new GenericRepository<BD_Transactions>(context);

                return transactionRepository;
            }
        }

        public GenericRepository<BD_TransactionDetails> TransactionDetailRepository
        {
            get
            {
                if (transactionDetailRepository == null)
                    transactionDetailRepository = new GenericRepository<BD_TransactionDetails>(context);

                return transactionDetailRepository;
            }
        }

        public GenericRepository<BD_Roles> RoleRepository
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new GenericRepository<BD_Roles>(context);

                return roleRepository;
            }
        }

        public GenericRepository<BD_Positions> PositionRepository
        {
            get
            {
                if (positionRepository == null)
                    positionRepository = new GenericRepository<BD_Positions>(context);

                return positionRepository;
            }
        }

        public GenericRepository<BD_UserRoles> UserRoleRepository
        {
            get
            {
                if (userRoleRepository == null)
                    userRoleRepository = new GenericRepository<BD_UserRoles>(context);

                return userRoleRepository;
            }
        }
        
        public GenericRepository<BD_MobileIndexes> MobileIndexRepository
        {
            get
            {
                if (mobileIndexRepository == null)
                    mobileIndexRepository = new GenericRepository<BD_MobileIndexes>(context);

                return mobileIndexRepository;
            }
        }
        
        public GenericRepository<BD_SupplierContacts> SupplierContactRepository
        {
            get
            {
                if (supplierContactRepository == null)
                    supplierContactRepository = new GenericRepository<BD_SupplierContacts>(context);

                return supplierContactRepository;
            }
        }

        public UnitOfWork()
        {
            context = new BeerDriveContext(Globals.ConnectionString);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
