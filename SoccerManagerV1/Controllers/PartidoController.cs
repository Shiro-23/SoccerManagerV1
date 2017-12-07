using SoccerManagerV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerManagerV1.Controllers
{
    public class PartidoController:Controller
    {
        SoccerManagerV1Entities3 cnx;


        public PartidoController()
        {
            cnx = new SoccerManagerV1Entities3();

        }
        public ActionResult RegistrarFecha()
        {

            return View();
        }       

        public ActionResult Partido()
        {

            return View();
        }

        public ActionResult InicioPartido()
        {

            return View();
        }
    }
}