using CMV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMV.Controllers
{
    public class ExempleController : Controller
    {
        // GET: Exemple
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Action01(Model01 m)
        {
            return View("Action01",m);
        }
        [HttpPost]
        public ViewResult Action02(model2 m)
        {
            return View("model2", m);
        }
    }
}