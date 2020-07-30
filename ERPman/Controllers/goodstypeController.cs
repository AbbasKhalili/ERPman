using System;
using System.Web.Mvc;
using Basicinfo.Application.Contract.GoodsGroup;
using Basicinfo.Application.Contract.GoodsType;
using Basicinfo.Interface.Facade.Contract;

namespace ERPman.Controllers
{
    public class GoodstypeController : BaseController
    {

        [HttpGet]
        public ActionResult Index()
        {
            var result = Query.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult Index2(SelectGoodsTypeQuery model)
        {
            return View();
        }

        [HttpPost]
        public void Create(SelectGoodsTypeQuery model)
        {
            model.Goodsgroups.Add(new SelectGoodsGroupQuery()
                                  {
                                      DateSave = DateTime.Now,
                                      GroupTitle = "G1",
                                      ParentId = 505,
                                      UserSave = "farhad"
            });
            model.Goodsgroups.Add(new SelectGoodsGroupQuery()
            {
                DateSave = DateTime.Now,
                GroupTitle = "G2",
                ParentId = 404,
                UserSave = "farhad"
            });
            Luncher.Execute(model, CommandType.Create, "farhad");
        }

        [HttpPost]
        public void Update(SelectGoodsTypeQuery model)
        {
            Luncher.Execute(model, CommandType.Update, "Admin");
        }

        [HttpPost]
        public void Delete(SelectGoodsTypeQuery model)
        {
            Luncher.Execute(model, CommandType.Delete, "Admin");
        }
    }
    
}