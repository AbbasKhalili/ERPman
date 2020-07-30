using System;
using Basicinfo.Application.Contract.Goods;
using Basicinfo.Domain.Model.Goods;
using Framework.Application;

namespace Basicinfo.Application.GoodsGroupType
{
    public class GoodsCommandHandler : ICommandHandler<CreateGoodsCommand>
    {
        private readonly IGoodsRepository _goodsrepository;

        public GoodsCommandHandler(IGoodsRepository goodsrepository)
        {
            _goodsrepository = goodsrepository;
        }
        
        public void Handle(CreateGoodsCommand handle)
        {
            _goodsrepository.Create(new Goods
            {
                Buyprice = handle.Buyprice ,
                GoodsName = handle.GoodsName ,
                GoodsCode = handle.GoodsCode,
                DateSave = DateTime.Now,
                GoodsGroupId = handle.GroupId ,
                GoodsTypeId = handle.TypeId,
                GoodsUnit = handle.GoodsUnit,
                Saleprice = handle.Saleprice ,
                UserSave = "Admin",
            });
        }
    }
}
