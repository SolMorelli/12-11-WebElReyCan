using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebElReyCan.Models;

namespace WebElReyCan.Data
{
    public class TurnoInitializer : DropCreateDatabaseAlways<TurnoDbContext>
    {
        protected override void Seed(TurnoDbContext context)
        {
            var turnos = new List<Turno>
            {
                new Turno
                {
                    Fecha = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString(),
                    Hora = "13:40",
                    NombreMascota = "Stefano",
                    Raza = "Mestizo",
                    Edad = 13,
                    NombreDuenio = "Mario",
                    Celular = "15-1111-1111"
                },
                 new Turno
                {
                    Fecha = "14/11/2021",
                    Hora = "16:30",
                    NombreMascota = "Turi",
                    Raza = "Mestizo",
                    Edad = 5,
                    NombreDuenio = "Almendra",
                    Celular = "15-2222-2222"
                },
                  new Turno
                {
                    Fecha = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString(),
                    Hora = "17:30",
                    NombreMascota = "Piltrafa",
                    Raza = "Atigrado",
                    Edad = 8,
                    NombreDuenio = "Esmé",
                    Celular = "15-3333-3333"
                },
                   new Turno
                {
                    Fecha = "13/11/2021",
                    Hora = "15:10",
                    NombreMascota = "Kelo",
                    Raza = "Mestizo",
                    Edad = 10,
                    NombreDuenio = "Aurora",
                    Celular = "15-4444-4444"
                },
                    new Turno
                {
                    Fecha = "13/11/2021",
                    Hora = "14:10",
                    NombreMascota = "Bebito",
                    Raza = "Mestizo",
                    Edad = 1,
                    NombreDuenio = "Diana",
                    Celular = "15-5555-5555"
                }
            };

            turnos.ForEach( turno => context.Turnos.Add(turno) );
            context.SaveChanges();
        }
    }

}