using Basicinfo.Domain.Model.Goods;

namespace Basicinfo.PersistenceEF.Repositories
{
    public class GoodsRepository : IGoodsRepository
    {
        private readonly BiContext _biContext;

        public GoodsRepository(BiContext biContext)
        {
            _biContext = biContext;
        }

        public void Create(Goods goods)
        {
            _biContext.SaveChanges();
        }
    }
}
