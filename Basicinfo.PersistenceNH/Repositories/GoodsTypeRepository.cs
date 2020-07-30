using System.Linq;
using Basicinfo.Domain.Model.GoodsType;
using NHibernate;
using NHibernate.Linq;

namespace Basicinfo.PersistenceNH.Repositories
{
    public class GoodsTypeRepository : IGoodsTypeRepository
    {
        private readonly ISession _session;

        public GoodsTypeRepository(ISession session)
        {
            _session = session;
        }

        public long Create(GoodsType aggregate)
        {
            return (long) _session.Save(aggregate);
        }

        public void Delete(GoodsType aggregate)
        {
            _session.Delete("GoodsType", aggregate.Id);
        }

        public void Update(GoodsType aggregate)
        {
            _session.SaveOrUpdate(aggregate);
            _session.Flush();
        }

        public IQueryable<GoodsType> GetAll()
        {
            return _session.Query<GoodsType>();
        }
    }
}
