using System;
using System.Linq;
using Basicinfo.Domain.Model.GoodsType;
using Framework.Core;

namespace Basicinfo.Domain.Validator
{
    public class GoodsTypeValidator : IGoodsTypeValidator
    {
        private readonly IGoodsTypeRepository _goodsTypeRepository;
        public GoodsTypeValidator(IGoodsTypeRepository goodsTypeRepository)
        {
            _goodsTypeRepository = goodsTypeRepository;
        }
        public void Validate(GoodsType entity)
        {
            if (entity.ParentId < 0)
                throw new BusinessException("0001","فیلد مربوط به پدر نمی تواند دارای مقدار منفی باشد.");


            var query = _goodsTypeRepository.GetAll().Where(z => z.TypeTitle == entity.TypeTitle);
            var cnt = 0;
            if (entity.Id == 0)
                cnt = query.ToList().Count;
            else if (entity.Id > 0)
                cnt = query.Where(z => z.Id != entity.Id).ToList().Count;

            if (cnt > 0)
                throw new BusinessException("0002","نوع کالای تکراری می باشد.");
        }
    }
}
