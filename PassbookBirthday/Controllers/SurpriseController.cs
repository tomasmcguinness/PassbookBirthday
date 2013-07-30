using PassbookBirthday.Models;
using PassVerse.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PassbookBirthday.Controllers
{
    public class SurpriseController : Controller
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
        public async Task<ActionResult> Create(SurpriseModel card)
        {
            if (ModelState.IsValid)
            {
                using (HttpClientHandler handler = new HttpClientHandler() { Credentials = new NetworkCredential("tomas@passverse.com", "Bjaxebh2") })
                {
                    HttpClient client = new HttpClient(handler);

                    PassModel pass = new PassModel();
                    pass.LogoText = card.Greeting;

                    HttpResponseMessage resp = await client.PutAsJsonAsync<PassModel>("https://passverseapi.azurewebsites.net/api/v1/pass/55ef5c60-a9a3-4947-afba-044a90e3a791", pass);

                    if (resp.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Manage");
                    }

                    ModelState.AddModelError("error", "The pass could not be generated!");

                    // Create a new pass and email it.
                    //
                    return View(card);
                }
            }
            else
            {
                return View(card);
            }
        }

        public ActionResult Manage()
        {
            SurpriseModel model = new SurpriseModel();
            model.Greeting = "Happy Birthday Chetna";
            model.SignatureLineOne = "Lots of Love,";
            model.signatureLineTwo = "Tom";

            return View(model);
        }
    }
}