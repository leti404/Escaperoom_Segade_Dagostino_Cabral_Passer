using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GravtiyFallsEscapeRoom.Models;

namespace GravtiyFallsEscapeRoom.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string nombJugador)
    {
        Escape.nombJugador = nombJugador;
        return RedirectToAction("Tutorial");
    }


    public IActionResult Tutorial()
    {
        ViewBag.PlayerName = Escape.nombJugador;
        return View();
    }

    public IActionResult Comenzar()
    {
        ViewBag.PlayerName = Escape.nombJugador;
        ViewBag.ErrorCod = Escape.NumError;
        string nivel = "Habitacion" + Escape.GetEstadoJuego();
        return View(nivel);
    }
    public IActionResult Creditos()
    {
        return View();
    }
    public IActionResult Habitacion(int sala, string clave, int NumError)
    {
        bool Resuelto;
        string nivel = "Habitacion" + Escape.GetEstadoJuego();
        Resuelto = Escape.ResolverSala(sala, clave);
        if (!Resuelto)
        {
            ViewBag.Error = "Clave incorrecta, intente nuevamente.";
            Escape.NumError++;
            return View("Habitacion" + sala);
        }
        return RedirectToAction("Comenzar");
    }
    public IActionResult Perdido()
    {
        return View();
    }
}
