using System.Collections.Generic;
using Basicinfo.Application.Contract.GoodsType;
using Framework.Core;

namespace Basicinfo.Interface.Facade.Contract
{
    public interface IGoodsTypeFacadeQuery : IFacadeService
    {
        List<SelectGoodsTypeQuery> GetAll();
    }
}
