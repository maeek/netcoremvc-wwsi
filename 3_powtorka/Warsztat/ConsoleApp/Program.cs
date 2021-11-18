using Domain;
using Persistence;
using System;

namespace ConsoleApp
{
  class Program
  {
    private static readonly string login = "Admin";
    private static readonly string password = "password";

    static void showMenu()
    {
      Console.WriteLine("dodaj");
      Console.WriteLine("usun");
      Console.WriteLine("wypisz");
      Console.WriteLine("zmien");
      Console.WriteLine("dodaj zamowienie");
      Console.WriteLine("lista zamowien");
      Console.WriteLine("wyjdz");
    }

    static void Main(string[] args)
    {
      Book book = new Book("Majnkraft", "Steve Jobs", 2001, "123123123", 14, 23);
      BooksRepository repository = new BooksRepository();

      Console.WriteLine("Podaj login: ");
      string username = Console.ReadLine();
      Console.WriteLine("Podaj hasło: ");
      string password = Console.ReadLine();

      if (username == Program.login && password == Program.password)
      {
        Console.WriteLine("Access Granted");
      }
      else
      {
        Console.WriteLine("Access Denied");
        return;
      }

      BooksRepository booksRepository = new BooksRepository();
      BooksService booksService = new BooksService(booksRepository);
      OrdersRepository ordersRepository = new OrdersRepository();
      OrdersService ordersService = new OrdersService(ordersRepository);

      bool isMenu = true;
      while (isMenu)
      {
        Program.showMenu();
        Console.WriteLine("Podaj komendę: ");
        var command = Console.ReadLine();

        switch (command)
        {
          case "wyjdz":
            isMenu = false;
            break;

          case "dodaj":
            booksService.AddBook();
            break;

          case "usun":
            booksService.RemoveBook();
            break;

          case "wypisz":
            booksService.ListBooks();
            break;

          case "zmien":
            booksService.ChangeState();
            break;

          case "dodaj zamowienie":
            ordersService.PlaceOrder();
            break;

          case "lista zamowien":
            ordersService.ListAll();
            break;

          default:
            Console.WriteLine("Komenda nieobsługiwana");
            break;
        }

        Console.WriteLine("Press AnyKey");
        Console.ReadKey();
        Console.Clear();
      }
    }
  }
}
