using System.Linq;
using Basicinfo.Domain.Model.InvoiceSale;
using NHibernate;
using NHibernate.Linq;

namespace Basicinfo.PersistenceNH.Repositories
{
    public class InvoiceSaleRepository : IInvoiceSaleRepository
    {
        private readonly ISession _session;

        public InvoiceSaleRepository(ISession session)
        {
            _session = session;
        }

        public long GetNextId()
        {
            return _session.CreateSQLQuery("SELECT NEXT VALUE FOR test").UniqueResult<long>();
        }

        public long Create(InvoiceSale aggregate)
        {
            return (long)_session.Save(aggregate);
        }

        public void Delete(InvoiceSale aggregate)
        {
            _session.Delete(aggregate);
            _session.Flush();
        }

        public void Update(InvoiceSale aggregate)
        {
            _session.SaveOrUpdate(aggregate);
            _session.Flush();
        }

        public IQueryable<InvoiceSale> GetAll()
        {
            return _session.Query<InvoiceSale>();
        }
    }
}
