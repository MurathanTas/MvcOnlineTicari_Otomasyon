using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        public ActionResult Index(int? id)
        {
            Context c = new Context();
            Class1 cs = new Class1();

            // Eğer id null değilse sorgu işlemi gerçekleştirilir
            if (id.HasValue)
            {
                cs.Deger1 = c.Uruns.Where(x => x.UrunID == id.Value).ToList();
                cs.Deger2 = c.Detays.Where(y => y.DetayID == 1).ToList();
            }
            else
            {
                // Eğer id null ise tüm verileri getir ya da başka bir varsayılan işlem yap
                cs.Deger1 = c.Uruns.ToList();
                cs.Deger2 = c.Detays.ToList();
            }

            return View(cs);
        }
    }
}