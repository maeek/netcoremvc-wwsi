using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
  public class Order
  {
    public DateTime Date { get; set; }
    public List<BookOrdered> BooksOrderedList { get; set; }

    public Order()
    {
      Date = DateTime.Now;
      BooksOrderedList = new List<BookOrdered>();
    }

    override public string ToString()
    {
      string str = "";

      str += "Order: " + Date.ToString() + "\n";

      for (int i = 0; i < BooksOrderedList.Count; i++)
      {
        str += $"Book: {BooksOrderedList[i].BookId} Count: {BooksOrderedList[i].NumberOrdered}\n";
      }

      return str;
    }
  }
}
