﻿using FilmDB.Models;
using System.Collections.Generic;

namespace FilmDB
{
  public interface IFilmManager
  {
    FilmManager AddFilm(FilmModel filmModel);
    FilmManager ChangeTitle(int id, string newTitle);
    FilmModel GetFilm(int id);
    List<FilmModel> GetFilms();
    FilmManager RemoveFilm(int id);
    FilmManager UpdateFilm(FilmModel filmModel);
  }
}