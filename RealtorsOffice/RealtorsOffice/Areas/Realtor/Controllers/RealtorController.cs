using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealtorsOffice.Areas.Realtor.Controllers
{
    public class RealtorController : Controller
    {
        [Authorize(Roles = "Realtor")]
        public ActionResult Index()
        {
            return View();
        }
    }
}