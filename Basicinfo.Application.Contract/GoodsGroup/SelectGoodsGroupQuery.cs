using System;

namespace Basicinfo.Application.Contract.GoodsGroup
{
    public class SelectGoodsGroupQuery
    {
        public long Id { get; set; }
        //public long GoodsTypeId { get; set; }
        public string GroupTitle { get; set; }
        public long ParentId { get; set; }
        public string UserSave { get; set; }
        public DateTime DateSave { get; set; }
        public string DateSaveFa => DateSave.ToPersianDate();
    }
}
