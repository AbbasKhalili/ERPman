using Framework.Domain;

namespace Basicinfo.Domain.Model.GoodsGroup
{
    public class GoodsGroup : EntityBase, IAggregateRoot
    {
        public string GroupTitle { get; set; }
        public long ParentId { get; set; }

        public long GoodsTypeId { get; set; }
        public virtual GoodsType.GoodsType GoodsType { get; set; }

        public GoodsGroup()
        {
            //Goodsgroups = new Collection<GoodsGroup.GoodsGroup>();
        }

        public GoodsGroup(long id, string groupTitle, long parentId, string usersave)//, IGoodsTypeValidator goodsTypeValidator)
        {
            GroupTitle = groupTitle;
            ParentId = parentId;
            this.Id = id;
            this.UserSave = usersave;
            //goodsTypeValidator.Validate(this);
        }

        public GoodsGroup(string groupTitle, long parentId, string usersave)//, IGoodsTypeValidator goodsTypeValidator)
        {
            GroupTitle = groupTitle;
            ParentId = parentId;
            this.UserSave = usersave;
            //goodsTypeValidator.Validate(this);
        }
    }
}
