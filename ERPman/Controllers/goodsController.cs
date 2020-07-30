using System.Web.Mvc;
using Basicinfo.Application.Contract.Goods;
using Framework.Application;

namespace ERPman.Controllers
{
    public class GoodsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Save(CreateGoodsCommand model)
        {
            //Bus.Dispatch(model);
        }
    }
}