using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Persistence;

namespace ConsoleApp
{
  public class OrdersService
  {
    OrdersRepository _repository;

    public OrdersService(OrdersRepository repository)
    {
      this._repository = repository;
    }

    public void PlaceOrder()
    {
      bool isMenu = true;
      var order = new Order();

      while (isMenu)
      {
        Console.WriteLine("add - dodaj pozycje do zamowienia");
        Console.WriteLine("end - zamknij zamowienie");
        var command = Console.ReadLine();

        if (command == "add")
        {
          Console.WriteLine("Podaj id ksiązki");
          var id = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Podaj ilosc");
          var quantity = Convert.ToInt32(Console.ReadLine());

          var bookOrdered = new BookOrdered();
          bookOrdered.BookId = id;
          bookOrdered.NumberOrdered = quantity;

          order.BooksOrderedList.Add(bookOrdered);
        }
        else if (command == "end")
        {
          isMenu = false;
          _repository.Insert(order);
        }
      }
    }

    public void ListAll()
    {
      var orders = _repository.GetAll();

      foreach (var order in orders)
      {
        Console.WriteLine($"Zamowienie z dnia {order.Date.ToString()}");
        foreach (var bookOrdered in order.BooksOrderedList)
        {
          Console.WriteLine($"Ksiazka {bookOrdered.BookId} x {bookOrdered.NumberOrdered}");
        }
      }
    }
  }
}
