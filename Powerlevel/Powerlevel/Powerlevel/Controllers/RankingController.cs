﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Powerlevel.Models;

namespace Powerlevel.Controllers
{
    public class RankingController : Controller
    {
        private toasterContext db = new toasterContext();

        /// <summary>
        /// Displays all current Powerlevel users
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
