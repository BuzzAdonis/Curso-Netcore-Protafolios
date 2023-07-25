using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiPortafolioAdonis.Models;

namespace MiPortafolioAdonis.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        /*   ViewBag.Nombre = "Adonis A. Severino";
           ViewBag.Lenguaje     = ".Net y Oracle";
           ViewBag.Edad         = 25;
           ViewBag.Suscriptores = "600,000 suscriptores";
           ViewBag.Imagen       = "/imagenes/batman-begins-2.jpg";*/
        Persona personas = new();
        personas.Edad = 25;
        personas.Lenguaje = ".Net y Oracle";
        personas.Nombre = "Adonis A. Severino";
        personas.Suscriptores = "600,000 suscriptores";
        personas.Avatar = "/imagenes/batman-begins-2.jpg";
        personas.Peso = 150;
        personas.Altura = 5.5;
        personas.Imc = calcularImc(personas.Peso, personas.Altura);
        return View("Index2", personas);

    }

    public IActionResult Indice()
    {
        return View("Index1");
    }

    public IActionResult Privacy()
    {   
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public double calcularImc(double peso, double altura)
    {
        return peso / (altura * altura) * 703;
    }
}

