using System.Collections.Generic;
using System.Linq;
using Basicinfo.Application.Contract.GoodsType;
using Basicinfo.Interface.Facade.Contract;
using Framework.Application;

namespace Basicinfo.Interface.Facade.Query
{
    public class GoodsTypeFacadeQuery : IGoodsTypeFacadeQuery
    {
        private readonly ICommandBus _bus;

        public GoodsTypeFacadeQuery()
        {
            _bus = new CommandBus();
        }

        
        List<SelectGoodsTypeQuery> IGoodsTypeFacadeQuery.GetAll()
        {
            return _bus.GetData<SelectGoodsTypeQuery>();
        }
    }
}
