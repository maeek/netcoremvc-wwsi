using Notes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Controllers
{
  public class HomeController : Controller
  {
    private readonly INoteManager _noteManager;

    public HomeController(INoteManager noteManager)
    {
      _noteManager = noteManager;
    }

    public IActionResult Index()
    {
      var notes = _noteManager.GetNotes();

      foreach (var note in notes)
      {
        try
        {
          note.Content = note.Content.Trim().Substring(0, 150);
        } catch (Exception)
        {
          continue;
        }
      }

      return View(notes);
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
      var note = _noteManager.GetNote(id);
      return View(note);
    }

    [HttpGet]
    public IActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Add(NoteModel note)
    {
      note.Created = DateTime.Now;
      note.Type = 1;
      _noteManager.AddNote(note);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Remove(int id)
    {
      var note = _noteManager.GetNote(id);
      return View(note);
    }

    [HttpPost]
    public IActionResult RemoveConfirm(int id)
    {
      _noteManager.RemoveNote(id);
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
      var note = _noteManager.GetNote(id);
      return View(note);
    }

    [HttpPost]
    public IActionResult Edit(NoteModel note)
    {
      _noteManager.UpdateNote(note);
      return RedirectToAction("Index");
    }
  }
}
