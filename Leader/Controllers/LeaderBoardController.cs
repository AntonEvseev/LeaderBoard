using Leader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Leader.Controllers
{
    public class LeaderBoardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}