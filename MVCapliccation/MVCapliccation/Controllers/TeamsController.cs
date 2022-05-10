using EGamezin.Models;
using Microsoft.AspNetCore.Mvc;

namespace EGamezin.Controllers
{
    public class TeamsController : Controller
    {
        /* ActionResult representa os varios codigos HTTP
         * Codigos HTTP - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status */


        Teams teamsModel = new Teams();

        public IActionResult Index()
        {

            //Viewbag = reserva de espaço para armazenar info para recuperar a VIEW e tambem pode "carregar" as info 
            // do controller para a VIEW 

            ViewBag.Teams = teamsModel.LerEquipes();

            return View();
        }
    }
}
