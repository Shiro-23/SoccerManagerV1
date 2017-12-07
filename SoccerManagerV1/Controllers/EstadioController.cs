using SoccerManagerV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerManagerV1.Controllers
{
    public class EstadioController:Controller
    {
        SoccerManagerV1Entities3 cnx;


        public EstadioController()
        {
            cnx = new SoccerManagerV1Entities3();

        }
        public ActionResult AñadirEst() { return View("AñadirEstadio"); }
        public ActionResult AñadirEstadio()
        {
            return View();
        }
        public ActionResult GuardarEstadio(String Estadio, String Direccion)
        {
            Estadio estadio = new Estadio()
            {
                Estadio1 = Estadio,
                Direccion = Direccion
            };
            cnx.Estadio.Add(estadio);
            cnx.SaveChanges();
            return View("Estadios", cnx.Estadio.ToList());
        }
        public ActionResult Estadios()
        {
            AñadirEstadio();
            return View("Estadios", cnx.Estadio.ToList());
        }
    }
}