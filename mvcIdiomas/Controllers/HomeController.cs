using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http.Results;
using System.Web.Mvc;
using mvcIdiomas.Models;

namespace mvcIdiomas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Persona model)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Index");
            return View(model);
        }

        public ActionResult Alta()
        {
            return RedirectToAction("Alta");
        }

        public ActionResult Correo()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Correo(Correo model)
        {
            var msg = new MailMessage();
            msg.Subject = model.Asunto;
            msg.Body = model.Mensaje;
            msg.To.Add(model.Destino);
            msg.IsBodyHtml = true;

            var smtp = new SmtpClient();

            try
            {
                smtp.Send(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index");
        }
    }
}
