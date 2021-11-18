using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Persistence;

namespace ConsoleApp
{
  public class BooksService
  {
    BooksRepository _repository;

    public BooksService(BooksRepository repository)
    {
      this._repository = repository;
    }

    public void AddBook()
    {
      Console.WriteLine("Podaj tytul:");
      var title = Console.ReadLine();
      Console.WriteLine("Podaj autora:");
      var author = Console.ReadLine();
      Console.WriteLine("Podaj rok publikacji:");
      var publicationYear = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Podaj isbn:");
      var isbn = Console.ReadLine();
      Console.WriteLine("Podaj ilość egzemplarzy:");
      var productsAvailable = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Podaj cene:");
      var price = Convert.ToDecimal(Console.ReadLine());

      Book book = new Book(title, author, publicationYear, isbn, productsAvailable, price);
      _repository.Insert(book);
    }

    public void RemoveBook()
    {
      Console.WriteLine("Podaj tytul ksiazki do usunięcia:");
      var tytul = Console.ReadLine();
      _repository.RemoveByTitle(tytul);
    }

    public void ListBooks()
    {
      _repository.GetAll().ForEach(book => Console.WriteLine(book));
    }

    public void ChangeState()
    {
      Console.WriteLine("Podaj tytul ksiazki do zmainy stanu:");
      var tytul = Console.ReadLine();

      Console.WriteLine("Podaj nowy stan:");
      var stan = Convert.ToInt32(Console.ReadLine());

      _repository.ChangeState(tytul, stan);
    }

  }
}
