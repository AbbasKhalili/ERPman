using System.Data.Entity.ModelConfiguration;
using Basicinfo.Domain.Model.Goods;

namespace Basicinfo.PersistenceEF.Mappings
{
    public class GoodsMapping : EntityTypeConfiguration<Goods>
    {
        public GoodsMapping()
        {            
            ToTable("Goods");
            HasKey(a => a.Id);
            HasRequired(a => a.GoodsName);
            HasRequired(a => a.GoodsGroup);
            HasRequired(a => a.GoodsType);
            
            //Property(a => a.RowVersion).IsRowVersion();
        }
    }
}
