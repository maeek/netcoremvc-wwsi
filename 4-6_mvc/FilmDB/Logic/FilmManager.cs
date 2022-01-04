using FilmDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB
{
  public class FilmManager : IFilmManager
  {
    private readonly FilmContext _context;

    public FilmManager(FilmContext context)
    {
      _context = context;
    }

    public FilmManager AddFilm(FilmModel filmModel)
    {
      _context.Database.EnsureCreated();
      _context.Films.Add(filmModel);
      try
      {
        _context.SaveChanges();
      }
      catch (Exception)
      {
        filmModel.ID = 0;
        _context.Films.Add(filmModel);
        _context.SaveChanges();
      }

      return this;
    }

    public FilmManager RemoveFilm(int id)
    {
      var film = _context.Films.SingleOrDefault(f => f.ID == id);
      _context.Remove(film);
      _context.SaveChanges();
      return this;
    }

    public FilmManager UpdateFilm(FilmModel filmModel)
    {
      _context.Update(filmModel);
      _context.SaveChanges();
      return this;
    }

    public FilmManager ChangeTitle(int id, string newTitle)
    {
      var film = this.GetFilm(id);
      film.Title = newTitle;
      this.UpdateFilm(film);

      return this;
    }

    public FilmModel GetFilm(int id)
    {
      return _context.Films.SingleOrDefault(f => f.ID == id);
    }

    public List<FilmModel> GetFilms()
    {

      return _context.Films.ToList();

    }
  }
}
