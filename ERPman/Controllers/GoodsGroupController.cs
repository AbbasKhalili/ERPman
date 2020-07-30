using System.Web.Mvc;
using Basicinfo.Application.Contract.GoodsGroup;

namespace ERPman.Controllers
{
    public class GoodsGroupController : BaseController
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Save(CreateGoodsGroupCommand model)
        {
            //this.Luncher.Execute(model);
        }
    }
}