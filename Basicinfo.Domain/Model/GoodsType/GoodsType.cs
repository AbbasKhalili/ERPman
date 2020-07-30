using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Framework.Domain;

namespace Basicinfo.Domain.Model.GoodsType
{
    public class GoodsType : EntityBase, IAggregateRoot
    {
        public string TypeTitle { get; set; }
        public long ParentId { get; set; }

        public virtual IList<GoodsGroup.GoodsGroup> Goodsgroups { get; set; }



        public GoodsType()
        {
            Goodsgroups = new List<GoodsGroup.GoodsGroup>();
        }

        public GoodsType(long id, string typeTitle,long parentId,string usersave, IGoodsTypeValidator goodsTypeValidator) 
        {
            TypeTitle = typeTitle;
            ParentId = parentId;
            this.Id = id;
            this.UserSave = usersave;
            Goodsgroups = new List<GoodsGroup.GoodsGroup>();
            goodsTypeValidator.Validate(this);
        }

        public GoodsType(string typeTitle, long parentId,string usersave, IGoodsTypeValidator goodsTypeValidator)
        {
            TypeTitle = typeTitle;
            ParentId = parentId;
            this.UserSave = usersave;
            Goodsgroups = new List<GoodsGroup.GoodsGroup>();
            goodsTypeValidator.Validate(this);
        }
    }
}
