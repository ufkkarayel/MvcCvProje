using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProje.Models.Entity;
using MvcCvProje.Repositories;

namespace MvcCvProje.Controllers
{
    public class YetenekController : Controller
    {
        DbCvEntities db =new  DbCvEntities();
        // GET: Yetenek
        public ActionResult Index()
        {
            var yetenekler = db.TblYeteneklerim.ToList();
            return View(yetenekler);
        }
    }
}