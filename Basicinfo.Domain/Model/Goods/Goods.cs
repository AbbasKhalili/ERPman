using Framework.Domain;

namespace Basicinfo.Domain.Model.Goods
{
    public class Goods : EntityBase, IAggregateRoot
    {
        public string GoodsName { get; set; }
        public string GoodsCode { get; set; }
        public int GoodsUnit { get; set; }
        public double Saleprice { get; set; }
        public double Buyprice { get; set; }

        public virtual GoodsGroup.GoodsGroup GoodsGroup { get; set; }
        public int GoodsGroupId { get; set; }
        public virtual GoodsType.GoodsType GoodsType { get; set; }
        public int GoodsTypeId { get; set; }
    }
}
