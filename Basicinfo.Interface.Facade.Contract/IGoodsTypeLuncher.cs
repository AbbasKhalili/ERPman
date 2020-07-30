using Basicinfo.Application.Contract.GoodsType;
using Framework.Core;

namespace Basicinfo.Interface.Facade.Contract
{
    public interface IGoodsTypeLuncher : IFacadeService
    {
        void Execute(SelectGoodsTypeQuery command, CommandType commandtype, string usersave);
    }
}
