using System.Collections.Generic;
using Basicinfo.Application.Contract.GoodsGroup;
using Framework.Core;

namespace Basicinfo.Application.Contract.GoodsType
{
    public class CreateGoodsTypeCommand : ICommand
    {
        public string TypeTitle { get; set; }
        public long ParentId { get; set; }
        public string UserSave { get; set; }
        public List<CreateGoodsGroupCommand> Goodsgroup { get; set; }

        public CreateGoodsTypeCommand()
        {
            Goodsgroup = new List<CreateGoodsGroupCommand>();
        }
    }
}
