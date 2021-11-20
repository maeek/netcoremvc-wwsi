using FilmDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB
{
  public class FilmManager
  {
    public FilmManager AddFilm(FilmModel filmModel)
    {
      using (var ctx = new FilmContext())
      {
        ctx.Database.EnsureCreated();
        ctx.Films.Add(filmModel);
        try
        {
          ctx.SaveChanges();
        }
        catch (Exception)
        {
          filmModel.ID = 0;
          ctx.Films.Add(filmModel);
          ctx.SaveChanges();
        }
      }
      return this;
    }

    public FilmManager RemoveFilm(int id)
    {
      using (var ctx = new FilmContext())
      {
        var film = ctx.Films.SingleOrDefault(f => f.ID == id);
        ctx.Remove(film);
        ctx.SaveChanges();
      }
      return this;
    }

    public FilmManager UpdateFilm(FilmModel filmModel)
    {
      using (var ctx = new FilmContext())
      {
        ctx.Update(filmModel);
        ctx.SaveChanges();
      }
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
      using (var ctx = new FilmContext())
      {
        return ctx.Films.SingleOrDefault(f => f.ID == id);
      }
    }

    public List<FilmModel> GetFilms()
    {
      using (var ctx = new FilmContext())
      {
        return ctx.Films.ToList();
      }
    }
  }
}
