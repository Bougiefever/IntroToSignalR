using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstSample.Controllers
{
    public class RealTimeController : Controller
    {
        // GET: RealTime
        public ActionResult PCChat()
        {
            return View();
        }

        public ActionResult BasicChat()
        {
            return View();
        }

        public ActionResult RoomChat()
        {
            return View();
        }
            
    }
}