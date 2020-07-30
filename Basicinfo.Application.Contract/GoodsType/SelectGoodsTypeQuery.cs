using System;
using System.Collections.Generic;
using Basicinfo.Application.Contract.GoodsGroup;
using Framework.Core;

namespace Basicinfo.Application.Contract.GoodsType
{
    public class SelectGoodsTypeQuery : ICommand
    {
        public long Id { get; set; }
        public string TypeTitle { get; set; }
        public long ParentId { get; set; }
        public string UserSave { get; set; }
        public DateTime DateSave { get; set; }
        public string DateSaveFa => DateSave.ToPersianDate();

        public List<SelectGoodsGroupQuery> Goodsgroups { get; set; }

        public SelectGoodsTypeQuery()
        {
            Goodsgroups = new List<SelectGoodsGroupQuery>();
        }
    }
}
