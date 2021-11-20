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
      FilmManager filmMan = new FilmManager();
      var films = filmMan.GetFilms();

      return View(films);
    }

    [HttpGet]
    public IActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Add(FilmModel film)
    {
      var manager = new FilmManager();
      manager.AddFilm(film);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Remove(int id)
    {
      var manager = new FilmManager();
      var film = manager.GetFilm(id);
      return View(film);
    }

    [HttpPost]
    public IActionResult RemoveConfirm(int id)
    {
      var manager = new FilmManager();
      manager.RemoveFilm(id);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
      var manager = new FilmManager();
      var film = manager.GetFilm(id);
      return View(film);
    }

    [HttpPost]
    public IActionResult Edit(FilmModel film)
    {
      var manager = new FilmManager();
      manager.UpdateFilm(film);
      return RedirectToAction("Index");
    }
  }
}
