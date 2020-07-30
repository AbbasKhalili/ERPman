using System.Data.Entity.ModelConfiguration;
using Basicinfo.Domain.Model.GoodsType;

namespace Basicinfo.PersistenceEF.Mappings
{
    public class GoodsTypeMapping : EntityTypeConfiguration<GoodsType>
    {
        public GoodsTypeMapping()
        {
            ToTable("GoodsType");
            HasKey(a => a.Id);
            HasRequired(a => a.TypeTitle);
        }
    }
}
