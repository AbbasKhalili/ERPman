using Basicinfo.Domain.Model.GoodsGroup;
using Basicinfo.Domain.Model.GoodsType;
using NHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;

namespace Basicinfo.PersistenceNH.Mappings
{
    public class GoodsGroupMapping : ClassMapping<GoodsGroup>
    {
        public GoodsGroupMapping()
        {
            Table("GoodsGroup");
            Lazy(false);

            Id(x => x.Id, map =>
            {
                map.Column("Id");
                map.Generator(Generators.Identity);
            });
            Property(x => x.GroupTitle, map => { map.Column("GroupTitle"); });
            Property(x => x.ParentId, map => { map.Column("ParentId"); });
            Property(x => x.UserSave, map => { map.Column("UserSave"); });
            Property(x => x.DateSave, map => { map.Column("DateSave"); });


            ManyToOne(p => p.GoodsType, map => map.Column("GoodsTypeId"));


            /*ManyToOne(x => x.GoodsType, map =>
            {
                map.Column("GoodsTypeId");
                map.Fetch(FetchKind.Join);
                map.NotNullable(true);
            });
            */
            

            /*ManyToOne(x => x.PropertyName, m =>
            {
                m.Column("column_name");
                // or...
                m.Column(c =>
                {
                    c.Name("column_name");
                    // other standard column options
                });

                m.Class(typeof(ClassName));
                m.Cascade(Cascade.All | Cascade.None | Cascade.Persist | Cascade.Remove);
                m.Fetch(FetchKind.Join); // or FetchKind.Select
                m.Update(true);
                m.Insert(true);
                m.Access(Accessor.Field);
                m.Unique(true);
                m.OptimisticLock(true);

                m.Lazy(LazyRelation.Proxy);

                //m.PropertyRef ???
                //m.NotFound ???

                m.ForeignKey("column_fk");
                m.Formula("arbitrary SQL expression");
                m.Index("column_idx");
                m.NotNullable(true);
                m.UniqueKey("column_uniq");
            });*/
        }
    }
}
