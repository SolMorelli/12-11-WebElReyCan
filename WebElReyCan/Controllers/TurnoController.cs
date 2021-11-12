using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        [HttpGet] // /Turno/Delete
        public ActionResult Delete(int id)
        {
            Turno turno = context.Turnos.Find(id);

            if (turno != null)
            {
                return View("Delete", turno);
            }

            return HttpNotFound();
        }

        [HttpPost] // /Turno/Delete
        public ActionResult Delete(Turno turno)
        {
            context.Turnos.Remove(context.Turnos.Find(turno.Id));
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet] // /Turno/Edit
        public ActionResult Edit(int id)
        {
            Turno turno = context.Turnos.Find(id);

            if (turno != null)
            {
                return View("Edit", turno);
            }

            return HttpNotFound();
        }

        [HttpPost] // /Turno/Edit
        public ActionResult Edit(Turno turno)
        {
            if (ModelState.IsValid)
            {
                context.Entry( context.Turnos.Find(turno.Id) ).State = EntityState.Detached;
                context.Entry(turno).State = EntityState.Modified;
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Edit", turno);
        }

        [HttpGet] // /Turno/GetByName
        public ActionResult GetByName(string name)
        {
            List<Turno> turnos =
            (
                from turno in context.Turnos
                where turno.NombreMascota == name
                select turno
            ).ToList<Turno>();

            if (turnos != null)
            {
                return View("Index", turnos);
            }

            return HttpNotFound();
        }

        [HttpGet] // /Turno/GetByCellphone
        public ActionResult GetByCellphone(string cellphone)
        {
            List<Turno> turnos =
            (
                from turno in context.Turnos
                where turno.Celular == cellphone
                select turno
            ).ToList<Turno>();

            if (turnos != null)
            {
                return View("Index", turnos);
            }

            return HttpNotFound();
        }
    }
}