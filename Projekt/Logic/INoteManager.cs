using Notes.Models;
using System.Collections.Generic;

namespace Notes
{
  public interface INoteManager
  {
    NoteManager AddNote(NoteModel noteModel);
    NoteManager ChangeName(int id, string newName);
    NoteModel GetNote(int id);
    List<NoteModel> GetNotes();
    NoteManager RemoveNote(int id);
    NoteManager UpdateNote(NoteModel noteModel);
  }
}