﻿using Framework.Core;

namespace Basicinfo.Application.Contract.GoodsType
{
    public class DeleteGoodsTypeCommand : ICommand
    {
        public long Id { get; set; }
        public string TypeTitle { get; set; }
        public long ParentId { get; set; }
        public string UserSave { get; set; }
    }
}
