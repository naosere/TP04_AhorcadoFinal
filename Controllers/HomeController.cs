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


    public ActionResult Jugar()
    {
        Juego.setearPalabra();
        ViewBag.palabraCorrecta = Juego.palabra;
        ViewBag.guiones = Juego.adivinados;
        ViewBag.cantidadFallidos = Juego.cantidadFallidos;
        ViewBag.arriesgosFallidos = Juego.arriesgosFallidos;
        return View("PantallaJuego");
    }


    [HttpPost]
    public ActionResult compararLetras(string letra)
    {
        letra = letra.ToLower();
        char ingreso = char.Parse(letra);
        Juego.verificarLetra(ingreso);
        ViewBag.palabraCorrecta = Juego.palabra;
        ViewBag.guiones = Juego.adivinados;
        ViewBag.cantidadFallidos = Juego.cantidadFallidos;
        ViewBag.arriesgosFallidos = Juego.arriesgosFallidos;
        return View("PantallaJuego");
    }


    [HttpPost]
    public ActionResult compararPalabra(string palabra)
    {
        ViewBag.palabraCorrecta = Juego.palabra;
        ViewBag.cantidadFallidos = Juego.cantidadFallidos;
        ViewBag.arriesgosFallidos = Juego.arriesgosFallidos;

        bool arriesgarPalabra = Juego.verificarPalabra(palabra);
        if (arriesgarPalabra)
        {
            return View("Gano");
        }
        else { return View("Perdio"); }

    }
}
