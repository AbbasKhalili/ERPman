using Basicinfo.Application.Contract.GoodsGroup;
using Basicinfo.Application.Contract.GoodsType;
using Basicinfo.Interface.Facade.Contract;
using Framework.Application;

namespace Basicinfo.Interface.CommandController
{
    public class GoodsTypeLuncher : IGoodsTypeLuncher
    {
        private readonly ICommandBus _bus;

        public GoodsTypeLuncher()
        {
            _bus = new CommandBus();
        }

        public void Execute(SelectGoodsTypeQuery command, CommandType commandtype, string usersave)
        {
            if (command != null)
            {
                switch (commandtype)
                {
                case CommandType.Create:
                {
                    var obj = new CreateGoodsTypeCommand()
                    {
                        TypeTitle = command.TypeTitle,
                        ParentId = command.ParentId,
                        UserSave = usersave
                    };
                    foreach (var itm in command.Goodsgroups)
                    {
                        obj.Goodsgroup.Add(new CreateGoodsGroupCommand()
                                           {
                                               GoodsTypeId = itm.Id,
                                               GroupTitle = itm.GroupTitle,
                                               ParentId = itm.ParentId
                                           });
                    }
                            
                    _bus.Dispatch(obj);   
                    break;
                }
                case CommandType.Update:
                {
                    var obj = new UpdateGoodsTypeCommand()
                    {
                        Id = command.Id,
                        TypeTitle = command.TypeTitle,
                        ParentId = command.ParentId,
                        UserSave = usersave
                    };
                    _bus.Dispatch(obj);
                    break;
                }
                case CommandType.Delete:
                {
                    var obj = new DeleteGoodsTypeCommand()
                    {
                        Id = command.Id,
                        TypeTitle = command.TypeTitle,
                        ParentId = command.ParentId,
                        UserSave = usersave
                    };
                    _bus.Dispatch(obj);
                    break;
                }
                }
            }
        }
    }
    
}
