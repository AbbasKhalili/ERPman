using System.Web.Http;
using Basicinfo.Application.Contract.GoodsType;
using Framework.Application;

namespace Basicinfo.Interface.RestApi
{
    public class GoodsTypeController : ApiController
    {
        private readonly ICommandBus _bus;

        public GoodsTypeController(ICommandBus bus)
        {
            _bus = bus;
        }

        public void Save(CreateGoodsTypeCommand model)
        {
            _bus.Dispatch(model);
        }
    }
}
