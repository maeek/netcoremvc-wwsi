using Notes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes
{
  public class NoteContext : DbContext
  {
    public DbSet<NoteModel> Notes { get; set; }

    public NoteContext(DbContextOptions<NoteContext> options) : base(options)
    {
    }
  }
}