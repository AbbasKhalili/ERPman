namespace Basicinfo.Application.Contract.GoodsGroupType
{
    public class CreateGoodsGroupCommand
    {
        public string GroupTitle { get; set; }
        public long ParentId { get; set; }
    }
}
