﻿using FilmDB.Models;
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
        try {
          ctx.SaveChanges();
        }
        catch (Exception) {
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
        var film = ctx.FilmDB.SingleOrDefault(f => f.ID == id);
        ctx.Films.Remove(film);
        ctx.SaveChanges();
      }
      return this;
    }

    public FilmManager UpdateFilm(FilmModel filmModel)
    {
      return this;
    }

    public FilmManager ChangeTitle(int id, string newTitle)
    {
      return this;
    }

    public FilmManager GetFilm(int id)
    {
      return null;
    }

    public List<FilmModel> GetFilms()
    {
      return null;
    }
  }
}