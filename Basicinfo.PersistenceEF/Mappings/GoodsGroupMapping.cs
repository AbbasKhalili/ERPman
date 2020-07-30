using System.Data.Entity.ModelConfiguration;
using Basicinfo.Domain.Model.GoodsGroup;

namespace Basicinfo.PersistenceEF.Mappings
{
    public class GoodsGroupMapping : EntityTypeConfiguration<GoodsGroup>
    {
        public GoodsGroupMapping()
        {
            ToTable("GoodsGroup");
            HasKey(a => a.Id);
            HasRequired(a => a.GroupTitle);
        }
    }
}
