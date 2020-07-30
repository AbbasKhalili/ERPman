using Basicinfo.Domain.Model.InvoiceSale;
using NHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Basicinfo.PersistenceNH.Mappings 
{
    public class InvoiceSaleChildMapping : ClassMapping<InvoiceSaleChild>
    {
        public InvoiceSaleChildMapping()
        {
            Table("InvoiceSaleChild");
            Lazy(false);
            
            Id(x => x.Id, map =>
            {
                map.Column("Id");
                map.Generator(Generators.Identity);
            });


            Property(x => x.Counts, map => { map.Column("Counts"); });
            Property(x => x.GoodsId, map => { map.Column("GoodsId"); });
            Property(x => x.Price, map => { map.Column("Price"); });
            Property(x => x.InvoiceSaleId, map => { map.Column("InvoiceSaleId");  });

            /*ManyToOne(x => x.InvoiceSale ,
                map => { //map.Class(typeof(InvoiceSale));
                map.Column("InvoiceSaleId");
                //map.Cascade(Cascade.All);
            });
            */

            //ManyToOne(p => p.InvoiceSale, map => map.Column("InvoiceSaleId"));

            
        }
    }
}
