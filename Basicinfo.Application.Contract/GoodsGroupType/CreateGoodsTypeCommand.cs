namespace Basicinfo.Application.Contract.GoodsGroupType
{
    public class CreateGoodsTypeCommand
    {
        public string TypeTitle { get; set; }
        public long ParentId { get; set; }
    }
}
