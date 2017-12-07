using SoccerManagerV1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SoccerManagerV1.Controllers
{
    public class HomeController : Controller
    {
        SoccerManagerV1Entities3 cnx;

       
        public HomeController()
        {
            cnx = new SoccerManagerV1Entities3();
           
        }
        
        
        
        public ActionResult Inicio()
        {
            return View();
        }          
    }
}