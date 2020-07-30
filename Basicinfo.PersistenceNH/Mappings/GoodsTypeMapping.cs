using Basicinfo.Domain.Model.GoodsGroup;
using Basicinfo.Domain.Model.GoodsType;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Basicinfo.PersistenceNH.Mappings
{
    public class GoodsTypeMapping : ClassMapping<GoodsType>
    {
        public GoodsTypeMapping()
        {
            Table("GoodsType");
            Lazy(false);

            Id(x => x.Id, map =>
            {
                map.Column("Id");
                map.Generator(Generators.Identity);
            });
            Property(x => x.TypeTitle, map => {map.Column("TypeTitle"); });
            Property(x => x.ParentId, map => { map.Column("ParentId"); });
            Property(x => x.UserSave, map => { map.Column("UserSave"); });
            Property(x => x.DateSave, map => { map.Column("DateSave"); });

            //HasMany(x => x.Addresses)
            //.Table("CustomerAddresses")
            //.KeyColumn("CustomerId")
            //.Component(m =>
            //{
            //    m.Map(x => x.Street1);
            //    m.Map(x => x.Street1);
            //    m.Map(x => x.City);
            //});

            
            //Bag(p => p.Goodsgroups, map => map.Key(k => k.Column("GoodsTypeId")), ce => ce.OneToMany());



            Bag(p => p.Goodsgroups, map => {
                map.Table("GoodsGroup");
                map.Key(k => k.Column("GoodsTypeId"));
            }, ce => ce.OneToMany());

            /*ManyToOne(x => x.Goodsgroups, map =>
            {
                map.Fetch(FetchKind.Join);
                map.ForeignKey("GoodsTypeId");
            });*/



            //Bag(x => x.Goodsgroups, c =>
            //{
            //    c.Key(k =>
            //    {
            //        k.Column("GoodsTypeId");
            //        k.NotNullable(true);
            //    });
            //    c.Cascade(Cascade.All);
            //    //c.Table("GoodsGroup");
            //    //c.Inverse(true);
            //}, r => r.OneToMany(m => { m.EntityName("GoodsGroup"); m.Class(typeof(GoodsGroup)); }));


        }
    }
}
