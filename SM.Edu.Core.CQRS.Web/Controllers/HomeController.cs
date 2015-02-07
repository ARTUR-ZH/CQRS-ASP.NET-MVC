using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SM.Edu.Core.Dominio.Commands;
using SM.Edu.Core;
using SM.Edu.Core.Dominio.Reporting;
using SM.Edu.Core.Dominio.Exceptions;

namespace SM.Edu.Core.Web.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Model = ServiceLocator.ReportDatabase.GetItems();
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpDelete]
        public ActionResult Delete(Guid id)
        {
            var item = ServiceLocator.ReportDatabase.GetById(id);
            ServiceLocator.CommandBus.Send(new DeleteItemCommand(item.Id,item.Version));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void Add(DiaryItemDto item)
        {
            ServiceLocator.CommandBus.Send(new CreateItemCommand(Guid.NewGuid(),item.Title,item.Description,-1,item.From,item.To));
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            var item = ServiceLocator.ReportDatabase.GetById(id);
            var model = new DiaryItemDto()
                {
                    Description = item.Description,
                    From = item.From,
                    Id = item.Id,
                    Title = item.Title,
                    To = item.To,
                    Version = item.Version
                };
            return View(model);
        }

        [HttpPost]
        public void Edit(DiaryItemDto item)
        {
            ServiceLocator.CommandBus.Send(new ChangeItemCommand(item.Id, item.Title, item.Description, item.From, item.To, item.Version));
        }
    }
}
