using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes.Models;
using Notes;

namespace Notes
{
  public class NoteManager : INoteManager
  {
    private readonly NoteContext _context;

    public NoteManager(NoteContext context)
    {
      _context = context;
    }

    public NoteManager AddNote(NoteModel noteModel)
    {
      _context.Database.EnsureCreated();
      _context.Notes.Add(noteModel);
      try
      {
        _context.SaveChanges();
      }
      catch (Exception)
      {
        noteModel.ID = 0;
        _context.Notes.Add(noteModel);
        _context.SaveChanges();
      }

      return this;
    }

    public NoteManager RemoveNote(int id)
    {
      var note = _context.Notes.SingleOrDefault(f => f.ID == id);
      _context.Remove(note);
      _context.SaveChanges();
      return this;
    }

    public NoteManager UpdateNote(NoteModel noteModel)
    {
      _context.Update(noteModel);
      _context.SaveChanges();
      return this;
    }

    public NoteModel GetNote(int id)
    {
      return _context.Notes.SingleOrDefault(f => f.ID == id);
    }

    public List<NoteModel> GetNotes()
    {
      return _context.Notes.ToList();

    }

    NoteManager INoteManager.ChangeName(int id, string newName)
    {
      var note = this.GetNote(id);
      note.Name = newName;
      this.UpdateNote(note);

      return this;
    }
  }
}
