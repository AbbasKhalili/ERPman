using Framework.Core;

namespace Basicinfo.Application.Contract.GoodsGroup
{
    public class CreateGoodsGroupCommand : ICommand
    {
        public string GroupTitle { get; set; }
        public long ParentId { get; set; }
        public long GoodsTypeId { get; set; }
    }
}
