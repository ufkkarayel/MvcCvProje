using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProje.Models.Entity;
using MvcCvProje.Repositories;

namespace MvcCvProje.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<Tblİletisim> repo = new GenericRepository<Tblİletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}