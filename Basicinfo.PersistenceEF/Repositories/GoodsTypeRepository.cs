using Basicinfo.Domain.Model.GoodsType;

namespace Basicinfo.PersistenceEF.Repositories
{
    public class GoodsTypeRepository : IGoodsTypeRepository
    {
        private readonly BiContext _biContext;

        public GoodsTypeRepository(BiContext biContext)
        {
            _biContext = biContext;
        }

        public void Create(GoodsType goodstype)
        {
            _biContext.SaveChanges();
        }
    }
}
