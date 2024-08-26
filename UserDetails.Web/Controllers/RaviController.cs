using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserDetails.Data.Model;
using UserDetails.Data.service;

namespace UserDetails.Web.Controllers
{
    public class RaviController : Controller
    {
        ChildAadharcard db;
        public RaviController()
        {
            this.db = new ChildAadharcard();
        }
        // GET: Ravi
        public ActionResult Index()
        {
           var model = db.GetAll();
            return View(model);
        }
    }
}