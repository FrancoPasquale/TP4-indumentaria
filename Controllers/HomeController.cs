using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View();
    }
    public IActionResult GuardarIndumentaria(string Equipo, int Media, int Pantalon, int Remera)
    {
        bool a = false;
        bool objetos2;
        if (Equipo == null || Media == null || Pantalon == null || Remera == null)
        {
            a = true;
            return View("SelectIndumentaria");  
        }
        else
        {
            Indumentaria objetos = new Indumentaria (Equipos.ListaMedias[Media], Equipos.ListaPantalones[Pantalon], Equipos.ListaRemeras[Remera]);
            objetos2 =Equipos.IngresarIndumentaria(Equipo,objetos);
                    ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;

            return View("Index");
        }
       
    }

}
