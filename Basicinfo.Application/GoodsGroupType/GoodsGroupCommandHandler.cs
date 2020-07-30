using Basicinfo.Application.Contract.GoodsGroup;
using Basicinfo.Domain.Model.GoodsGroup;
using Framework.Application;

namespace Basicinfo.Application.GoodsGroupType
{
    public class GoodsGroupCommandHandler : ICommandHandler<CreateGoodsGroupCommand>
    {
        private readonly IGoodsGroupRepository _goodsGroupRepository;
        public GoodsGroupCommandHandler(IGoodsGroupRepository goodsGroupRepository)
        {
            _goodsGroupRepository = goodsGroupRepository;
        }
        
        public void Handle(CreateGoodsGroupCommand handle)
        {
            _goodsGroupRepository.Create(new GoodsGroup
            {                 
                GroupTitle = handle.GroupTitle,
                ParentId = handle.ParentId,
                UserSave = "Admin"
            });
        }
    }
}
