using System.Linq;
using Basicinfo.Domain.Model.Goods;
using NHibernate;
using NHibernate.Linq;

namespace Basicinfo.PersistenceNH.Repositories
{
    public class GoodsRepository : IGoodsRepository
    {
        private readonly ISession _session;

        public GoodsRepository(ISession session)
        {
            _session = session;
        }

        public long Create(Goods aggregate)
        {
            return (long) _session.Save(aggregate);
        }

        public void Delete(Goods aggregate)
        {
            _session.Delete(aggregate);
        }

        public void Update(Goods aggregate)
        {
            _session.Update(aggregate);
        }

        public IQueryable<Goods> GetAll()
        {
            return _session.Query<Goods>();
        }
    }
}
