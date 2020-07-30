using System.Collections.Generic;
using System.Linq;
using Basicinfo.Application.Contract.GoodsType;
using Basicinfo.Domain.Model.GoodsType;
using Framework.Application;

namespace Basicinfo.Application.GoodsGroupType
{
    public class GoodsTypeQueryHandler : IQueryHandler<SelectGoodsTypeQuery>
    {
        private readonly IGoodsTypeRepository _goodsTypeRepository;

        public GoodsTypeQueryHandler(IGoodsTypeRepository goodsTypeRepository)
        {
            _goodsTypeRepository = goodsTypeRepository;
        }

    
        List<SelectGoodsTypeQuery> IQueryHandler<SelectGoodsTypeQuery>.Handle()
        {
            var tmp = _goodsTypeRepository.GetAll().ToList();
            var result = new List<SelectGoodsTypeQuery>();
            foreach (var itm in tmp)
            {
                result.Add(new SelectGoodsTypeQuery()
                {
                    Id = itm.Id,
                    TypeTitle = itm.TypeTitle,
                    ParentId = itm.ParentId,
                    DateSave = itm.DateSave,
                    UserSave = itm.UserSave
                });
            }
            return result;
        }
    }
}
