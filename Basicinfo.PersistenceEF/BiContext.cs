using System.Data.Entity;
using Basicinfo.Domain.Model.Goods;
using Basicinfo.Domain.Model.GoodsGroup;
using Basicinfo.Domain.Model.GoodsType;

namespace Basicinfo.PersistenceEF
{
    public class BiContext : DbContext
    {
        public DbSet<Goods> Goods { get; set; }
        public DbSet<GoodsGroup> GoodsGroup { get; set; }
        public DbSet<GoodsType> GoodsType { get; set; }

        public BiContext():base("DBConnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(BiContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
