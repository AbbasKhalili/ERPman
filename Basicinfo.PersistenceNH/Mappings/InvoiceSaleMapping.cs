using Basicinfo.Domain.Model.InvoiceSale;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Basicinfo.PersistenceNH.Mappings
{
    public class InvoiceSaleMapping : ClassMapping<InvoiceSale>
    {
        public InvoiceSaleMapping()
        {
            Table("InvoiceSale");
            Lazy(false);

            Id(x => x.Id, map =>
            {
                map.Column("Id");
                map.Generator(Generators.Identity);
            });


            Id(x => x.SeqId, map =>
            {
                map.Column("SeqId");
                map.Generator(Generators.Assigned);
            });

            Property(x => x.TotalSum, map => { map.Column("TotalSum"); });
            Property(x => x.InvoiceDate, map => { map.Column("InvoiceDate"); });
            Property(x => x.UserSave, map => { map.Column("UserSave"); });
            Property(x => x.DateSave, map => { map.Column("DateSave"); });
            
            Set(p => p.Children, map => { map.Key(k => k.Column("InvoiceSaleId"));
                                            map.Inverse(true);
                                            map.Cascade(Cascade.All);
            }, ce => ce.OneToMany(a => a.Class(typeof(InvoiceSaleChild))));

            
        }
    }
}
