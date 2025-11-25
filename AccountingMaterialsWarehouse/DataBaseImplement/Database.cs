using Contract.StorageModel.dbModel;
using Microsoft.EntityFrameworkCore;

namespace DataBaseImplement
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=WIN-0IL5NARLEQ9\SQLEXPRESS;Initial Catalog=Variant9;Integrated Security=True;MultipleActiveResultSets=True;;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ChartOfAccount> ChartOfAccounts { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MOL> MOLs { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }
    }
}
