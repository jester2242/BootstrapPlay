using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapPlay.Models;
using GridMvc.Html;

namespace BootstrapPlay.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Single(SingleModel singleModel)
        {

            singleModel.GroupName = singleModel.GroupName + " w00t";
            return RedirectToAction("Display", singleModel);
           
        }

        public ActionResult Display(SingleModel singleModel)
        {
            MulitModel model = new MulitModel();
            model.GroupName = singleModel.GroupName;
            model.FooThings = new List<itemfoo>() { new itemfoo() { Id = 1, Foo = "Hamster" }, new itemfoo() { Id = 2, Foo = "Gerbil" }, new itemfoo() { Id = 3, Foo = "Vole" } };
            


            return View("Display", model);
        }
        [HttpPost]
        public ActionResult Create(itemfoo model)
        {            
            return View(model);
        }
    }
}