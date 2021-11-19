using FilmDB.Models;
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = @"Data Source=localhost;Initial Catalog=FilmDB;Integrated Security=True";
            optionsBuilder.UseSqlServer(con);
        }
    }
}