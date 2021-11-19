using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Controllers
{
  public class FilmController : Controller
  {
    public IActionResult Index()
    {
      FilmModel film = new FilmModel();
      film.ID = 1;
      film.Title = "Auta";
      film.Year = 2007;

      FilmManager filmMan = new FilmManager();

      filmMan.AddFilm(film);

      return View();
    }
  }
}
