using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetReal.Controllers
{
    public class RealtorsController : Controller
    {
        private RealtorService realtorService = new RealtorService();

        // GET: Realtors
        public ActionResult Index()
        {

            return View(realtorService.GetRealtorList());
        }
    }
}