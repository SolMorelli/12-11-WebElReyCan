using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{
    public class TurnoController : Controller
    {
        private static TurnoDbContext context = new TurnoDbContext();

        [HttpGet] // /Turno/Index
        public ActionResult Index()
        {
            string fechaActual = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            List<Turno> turnos =
            (
                from turno in context.Turnos
                where turno.Fecha == fechaActual
                select turno
            ).ToList<Turno>();

            if (turnos != null)
            {
                return View("Index", turnos);
            }

            return HttpNotFound();
        }

        [HttpGet] // /Turno/Create
        public ActionResult Create()
        {
            return View( "Create", new Turno() );
        }

        [HttpPost] // /Turno/Create
        public ActionResult Create(Turno turno)
        {
            if (ModelState.IsValid)
            {
                context.Turnos.Add(turno);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Create", turno);
        }

    }
}