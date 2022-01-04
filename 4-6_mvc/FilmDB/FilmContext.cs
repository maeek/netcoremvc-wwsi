﻿using FilmDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB
{
  public class FilmContext : DbContext
  {
    public DbSet<FilmModel> Films { get; set; }

    public FilmContext(DbContextOptions<FilmContext> options) : base(options)
    {
    }
  }
}