using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tahseen.Controllers
{
    public class docController : Controller
    {
        // GET: doc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult files()
        {
            return View();
        }
        public ActionResult cdata()
        {
            return View();
        }



    }
}