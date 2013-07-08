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
            using (HttpClientHandler handler = new HttpClientHandler() { Credentials = new NetworkCredential() })
            {
                HttpClient client = new HttpClient(handler);

                PassModel pass = new PassModel();

                HttpResponseMessage resp = await client.PutAsJsonAsync<PassModel>("https://passverseapi.azurewebsites.net/api/v1/pass/e5bea643-0a63-4162-a753-c39f0b0c3c4c", pass);



                // Create a new pass and email it.
                //
                return View();
            }
        }
    }
}