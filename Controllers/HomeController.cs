using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Web_StarWars.Models;
using Web_StarWars.Services;

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

    public async Task<ActionResult> Films()
    {
      ViewBag.Message = "Star Wars Films";

      HttpService service = new HttpService();

      Results<Film> result = await service.GetAsync<Results<Film>>("http://swapi.dev/api/films");

      IEnumerable<Film> res = result.results;

      return View(res);
    }

    public async Task<ActionResult> GetFilmDetail(string url)
    {
      return null;
    }
  }
}
