using BeerDrive.DAL.Basics;
using BeerDrive.DAL.Implementations;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace BeerDrive.DAL.Context
{
    public partial class BeerDriveContext : DbContext
    {
        //public BeerDriveContext(string connectionString)
        //    : base("name=BeerDriveContext")
        //{
        //}

        public BeerDriveContext(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<BD_Categories> BD_Categories { get; set; }
        public virtual DbSet<BD_Users> BD_Users { get; set; }
        public virtual DbSet<BD_Customers> BD_Customers { get; set; }
        public virtual DbSet<BD_MobileIndexes> BD_MobileIndexes { get; set; }
        public virtual DbSet<BD_MeasureUnitTypes> BD_MeasureUnitTypes { get; set; }
        public virtual DbSet<BD_OrderDetails> BD_OrderDetails { get; set; }
        public virtual DbSet<BD_Orders> BD_Orders { get; set; }
        public virtual DbSet<BD_Positions> BD_Positions { get; set; }
        public virtual DbSet<BD_Products> BD_Products { get; set; }
        public virtual DbSet<BD_SupplierContacts> BD_SupplierContacts { get; set; }
        public virtual DbSet<BD_Suppliers> BD_Suppliers { get; set; }
        public virtual DbSet<BD_Transactions> BD_Transactions { get; set; }
        public virtual DbSet<BD_TransactionDetails> BD_TransactionDetails { get; set; }
        public virtual DbSet<BD_PayTypes> BD_PayTypes { get; set; }
        public virtual DbSet<BD_TransactionStatusTypes> BD_TransactionStatusTypes { get; set; }
        public virtual DbSet<BD_Roles> BD_Roles { get; set; }
        public virtual DbSet<BD_UserRoles> BD_UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BD_Categories>()
                .HasMany(e => e.BD_Products)
                .WithRequired(e => e.BD_Categories)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Users>()
                .HasMany(e => e.BD_Orders)
                .WithRequired(e => e.BD_Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_MobileIndexes>()
                .HasMany(e => e.BD_SupplierContacts)
                .WithRequired(e => e.BD_MobileIndexes)
                .HasForeignKey(e => e.MobileIndexId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_OrderDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BD_Orders>()
                .HasMany(e => e.BD_OrderDetails)
                .WithRequired(e => e.BD_Orders)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Positions>()
                .HasMany(e => e.BD_Users)
                .WithRequired(e => e.BD_Positions)
                .HasForeignKey(e => e.PositionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Products>()
                .HasMany(e => e.BD_OrderDetails)
                .WithRequired(e => e.BD_Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Products>()
                .HasMany(e => e.BD_TransactionDetails)
                .WithRequired(e => e.BD_Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_SupplierContacts>()
                .HasMany(e => e.BD_Suppliers)
                .WithRequired(e => e.BD_SupplierContacts)
                .HasForeignKey(e => e.ContactId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Suppliers>()
                .HasMany(e => e.BD_Products)
                .WithRequired(e => e.BD_Suppliers)
                .HasForeignKey(e => e.SupplierId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_MeasureUnitTypes>()
                .HasMany(e => e.BD_Products)
                .WithRequired(e => e.BD_MeasureUnitTypes)
                .HasForeignKey(e => e.MeasureUnitTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_TransactionStatusTypes>()
                .HasMany(e => e.BD_Transactions)
                .WithRequired(e => e.BD_TransactionStatusTypes)
                .HasForeignKey(e => e.TransactionStatusTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Transactions>()
                .HasMany(e => e.BD_TransactionDetails)
                .WithRequired(e => e.BD_Transactions)
                .HasForeignKey(e => e.TransactionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Transactions>();

            modelBuilder.Entity<BD_PayTypes>()
                .HasMany(e => e.BD_Transactions)
                .WithRequired(e => e.BD_PayTypes)
                .HasForeignKey(e => e.PayTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Users>()
                .HasMany(e => e.BD_Transactions)
                .WithRequired(e => e.BD_Users)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BD_Users>()
            //    .HasMany(e => e.BD_Roles)
            //    .WithMany(e => e.BD_Users)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("UserId");
            //        cs.MapRightKey("RoleId");
            //        cs.ToTable("BD_UserRoles");
            //    });

            modelBuilder.Entity<BD_Users>()
                .HasMany(e => e.BD_UserRoles)
                .WithRequired(e => e.BD_Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BD_Roles>()
                .HasMany(e => e.BD_UserRoles)
                .WithRequired(e => e.BD_Roles)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);
        }

        public override Task<int> SaveChangesAsync()
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
                Audition(entry);

            return base.SaveChangesAsync();
        }

        private void Audition(DbEntityEntry<AuditableEntity> entry)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.DateCreated = DateTime.Now;
                    entry.Entity.CreatedBy = Identity.User.Id;
                    break;
                case EntityState.Modified:
                    entry.Entity.DateChanged = DateTime.Now;
                    entry.Entity.ChangedBy = Identity.User.Id;

                    entry.Property(nameof(AuditableEntity.CreatedBy)).IsModified = false;
                    entry.Property(nameof(AuditableEntity.DateCreated)).IsModified = false;

                    entry.Property(nameof(AuditableEntity.DeletedBy)).IsModified = false;
                    entry.Property(nameof(AuditableEntity.DateDeleted)).IsModified = false;
                    break;
                case EntityState.Deleted:
                    entry.State = EntityState.Unchanged;

                    entry.Entity.DateDeleted = DateTime.Now;
                    entry.Entity.DeletedBy = Identity.User.Id;
                    break;
            }
        }
    }
}
