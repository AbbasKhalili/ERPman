using System.Linq;
using Basicinfo.Domain.Model.GoodsGroup;
using NHibernate;
using NHibernate.Linq;

namespace Basicinfo.PersistenceNH.Repositories
{
    public class GoodsGroupRepository : IGoodsGroupRepository
    {
        private readonly ISession _session;

        public GoodsGroupRepository(ISession session)
        {
            _session = session;
        }

        public long Create(GoodsGroup aggregate)
        {
            return (long)_session.Save(aggregate);
        }

        public void Delete(GoodsGroup aggregate)
        {
            _session.Delete(aggregate);
        }

        public void Update(GoodsGroup aggregate)
        {
            _session.Update(aggregate);
        }

        public IQueryable<GoodsGroup> GetAll()
        {
            return _session.Query<GoodsGroup>();
        }
    }
}
