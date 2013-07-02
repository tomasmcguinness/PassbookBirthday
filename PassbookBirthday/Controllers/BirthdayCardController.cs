using PassbookBirthday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace PassbookBirthday.Controllers
{
    public class BirthdayCardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BirthdayCardModel card)
        {
            // Create a new pass and email it.
            //
            return View();
        }
    }
}