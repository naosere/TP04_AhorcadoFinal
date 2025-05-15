using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_AhorcadoFinal.Models;

namespace TP04_AhorcadoFinal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index()
    {
        return View();
    }


    public ActionResult Jugar(){
        return View("PantallaJuego");
    }

        [HttpPost]
    public ActionResult compararLetras(char letra){
        Juego.setearPalabra();
        Juego.verificarLetra(letra);
        return View("PantallaJuego");
    }


    public ActionResult compararPalabra(string palabra){
        bool arriesgarPalabra = Juego.verificarPalabra(palabra);
        ViewBag.palabraCorrecta = Juego.palabra;
        if (arriesgarPalabra)
        {
            return View ("Gano");
        }else{return View("Perdio");}

    }
}
