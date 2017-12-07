using SoccerManagerV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerManagerV1.Controllers
{
    public class EquipoController : Controller
    {
        SoccerManagerV1Entities3 cnx;


        public EquipoController()
        {
            cnx = new SoccerManagerV1Entities3();

        }

        public ActionResult GuardarEquipo(String NombreEquipo, String Estadio)
        {
            Equipo equipo = new Equipo()
            {
                NombreEquipo = NombreEquipo,
                EstadioEquipo = Estadio
            };
            cnx.Equipo.Add(equipo);
            cnx.SaveChanges();
            return View("ListaDeEquipos", cnx.Equipo.ToList());
        }
        public ActionResult CrearEquipo()
        {
            ListaEstadio();
            return View();
        }
        public ActionResult ListaDeEquipos()
        {

            return View(cnx.Equipo.ToList());
        }

        public ActionResult ListaEstadio()
        {
            var getEstadioList = cnx.Estadio.ToList();
            SelectList list = new SelectList(getEstadioList, "Id","Estadio1");
            ViewBag.EstadioLista = list;
            return View();
        }
    } 
}