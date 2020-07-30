using Basicinfo.Domain.Model.Goods;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Basicinfo.PersistenceNH.Mappings
{
    public class GoodsMapping : ClassMapping<Goods>
    {
        public GoodsMapping()
        {
            Table("Goods");
            Lazy(false);

            Id(x => x.Id, map =>
            {
                map.Column("Id");
                map.Generator(Generators.Identity);
            });
            Property(x => x.Buyprice, map => { map.Column("Buyprice"); });
            Property(x => x.GoodsCode, map => { map.Column("GoodsCode"); });
            Property(x => x.GoodsGroupId, map => { map.Column("GoodsGroup"); });
            Property(x => x.GoodsName, map => { map.Column("GoodsName"); });
            Property(x => x.GoodsTypeId, map => { map.Column("GoodsType"); });
            Property(x => x.GoodsUnit, map => { map.Column("GoodsUnit"); });
            Property(x => x.Saleprice, map => { map.Column("Saleprice"); });
            Property(x => x.UserSave, map => { map.Column("UserSave"); });
            Property(x => x.DateSave, map => { map.Column("DateSave"); });
        }
    }

}