
using Framework.Core;

namespace Basicinfo.Application.Contract.Goods
{
    public class CreateGoodsCommand : ICommand
    {
        public string GoodsName { get; set; }
        public string GoodsCode { get; set; }
        public int GoodsUnit { get; set; }
        public double Saleprice { get; set; }
        public double Buyprice { get; set; }

        public int GroupId { get; set; }
        public int TypeId { get; set; }
    }
}
