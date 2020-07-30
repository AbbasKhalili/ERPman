using Basicinfo.Domain.Model.GoodsGroup;

namespace Basicinfo.PersistenceEF.Repositories
{
    public class GoodsGroupRepository : IGoodsGroupRepository
    {
        private readonly BiContext _biContext;

        public GoodsGroupRepository(BiContext biContext)
        {
            _biContext = biContext;
        }

        public void Create(GoodsGroup goodsgroup)
        {
            _biContext.SaveChanges();
        }
    }
}
