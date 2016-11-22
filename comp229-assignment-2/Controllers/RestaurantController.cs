using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;
using comp229_assignment_2.Models;

namespace comp229_assignment_2.Controllers {
    public class RestaurantController : Controller {
        private RestaurantContext db = new RestaurantContext();


        // GET: Restaurant
        public ActionResult Index() {

            String FilePath = Server.MapPath("~/Assets/images");

            IEnumerable<string> files = Directory.GetFiles(FilePath).Select(f => "/Assets/images/" + Path.GetFileName(f));

            ViewBag.files = files;

            return View(db.Dishes.ToList());
        }
    }
}
