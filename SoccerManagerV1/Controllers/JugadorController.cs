using SoccerManagerV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerManagerV1.Controllers
{
    public class JugadorController:Controller
    {
        SoccerManagerV1Entities3 cnx;


        public JugadorController()
        {
            cnx = new SoccerManagerV1Entities3();

        }
        public ActionResult GuardarJuagador(int Rut, String DV, String Nombres, String Apellidopaterno, String Apellidomaterno, DateTime Fechanacimiento, String Equipo)
        {
            Jugador jugador = new Jugador
            {
                Rut=Rut,
                DV=DV,
                Nombre=Nombres,
                ApellidoPaterno=Apellidopaterno,
                ApellidoMaterno=Apellidomaterno,
                FechaNac=Fechanacimiento,
                EquipoJugador=Equipo
            };
            cnx.Jugador.Add(jugador);
            cnx.SaveChanges();

            return View("ListaDeJugadores", cnx.Jugador.ToList());
        }
        public ActionResult RegistrarJugador()
        {
            ListaEquipo();
            return View();
        }
        
        public ActionResult ListaDeJugadores()
        {

            return View("ListaDeJugadores", cnx.Jugador.ToList());
        }
        public ActionResult RegistroHuella()
        {


            return View();
        }

        public ActionResult ListaEquipo()
        {
            var getEquipoList = cnx.Equipo.ToList();
            SelectList list = new SelectList(getEquipoList, "Id", "NombreEquipo");
            ViewBag.EquipoLista = list;
            return View();
        }
    }
}