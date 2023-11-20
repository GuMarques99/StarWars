using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Web_StarWars.Services;
using StarWarsApiCSharp;

namespace Web_StarWars.Controllers
{
  public class HomeController : Controller
  { 
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    { 
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    public ActionResult Films()
    {
      IRepository<StarWarsApiCSharp.Film> filmsRepo = new Repository<StarWarsApiCSharp.Film>();
      var films = filmsRepo.GetEntities(size: int.MaxValue).ToList();
      return View(films);
    }
    public ActionResult Characters()
    {
      IRepository<StarWarsApiCSharp.Person> filmsRepo = new Repository<StarWarsApiCSharp.Person>();
      var people = filmsRepo.GetEntities(size: int.MaxValue).ToList();
      return View(people);
    }

    public ActionResult Planets()
    {
      IRepository<StarWarsApiCSharp.Planet> filmsRepo = new Repository<StarWarsApiCSharp.Planet>();
      var planets = filmsRepo.GetEntities(size: int.MaxValue).ToList();
      return View(planets);
    }

    public ActionResult Species()
    {
      IRepository<StarWarsApiCSharp.Specie> filmsRepo = new Repository<StarWarsApiCSharp.Specie>();
      var species = filmsRepo.GetEntities(size: int.MaxValue).ToList();
      return View(species);
    }

    public ActionResult Starships()
    {
      IRepository<StarWarsApiCSharp.Starship> filmsRepo = new Repository<StarWarsApiCSharp.Starship>();
      var starships = filmsRepo.GetEntities(size: int.MaxValue).ToList();
      return View(starships);
    }

    public ActionResult Vehicles()
    {
      IRepository<StarWarsApiCSharp.Vehicle> filmsRepo = new Repository<StarWarsApiCSharp.Vehicle>();
      var starships = filmsRepo.GetEntities(size: int.MaxValue).ToList();
      return View(starships);
    }
  }
}
