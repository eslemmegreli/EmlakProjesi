using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmlakProje.Models.Entity;


namespace EmlakProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        dbemlakEntities db = new dbemlakEntities();
        public ActionResult Index()
        {
            var degerler = db.tblEvler.ToList();
            return View(degerler);
        }
    }
}