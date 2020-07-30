using Basicinfo.Application.Contract.GoodsType;
using Basicinfo.Domain.Model.GoodsGroup;
using Basicinfo.Domain.Model.GoodsType;
using Framework.Application;

namespace Basicinfo.Application.GoodsGroupType
{
    public class GoodsTypeCommandHandler : ICommandHandler<CreateGoodsTypeCommand>,
                                           ICommandHandler<UpdateGoodsTypeCommand>,
                                           ICommandHandler<DeleteGoodsTypeCommand>
    {
        private readonly IGoodsTypeRepository _goodsTypeRepository;
        private readonly IGoodsTypeValidator _goodsTypeValidator;
        public GoodsTypeCommandHandler(IGoodsTypeRepository goodsTypeRepository, IGoodsTypeValidator goodsTypeValidator)
        {
            _goodsTypeRepository = goodsTypeRepository;
            _goodsTypeValidator = goodsTypeValidator;
        }

        public void Handle(CreateGoodsTypeCommand handle)
        {
            var obj = new GoodsType(handle.TypeTitle, handle.ParentId, handle.UserSave, _goodsTypeValidator);
            foreach (var x in handle.Goodsgroup)
            {
                obj.Goodsgroups.Add(new GoodsGroup(x.GroupTitle, x.ParentId, "www"));
            }
            _goodsTypeRepository.Create(obj);
            //_goodsTypeRepository.Create(new GoodsType(handle.TypeTitle, handle.ParentId,handle.UserSave, _goodsTypeValidator));
        }

        public void Handle(UpdateGoodsTypeCommand handle)
        {
            _goodsTypeRepository.Update(new GoodsType(handle.Id, handle.TypeTitle, handle.ParentId, handle.UserSave, _goodsTypeValidator));
        }

        public void Handle(DeleteGoodsTypeCommand handle)
        {
            _goodsTypeRepository.Delete(new GoodsType(handle.Id, handle.TypeTitle, handle.ParentId, handle.UserSave, _goodsTypeValidator));
        }
        
    }
}
