using System;

namespace Notes.Models
{
  public class NoteModel
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public int Type { get; set; }
    public string Content { get; set; }
  }
}
