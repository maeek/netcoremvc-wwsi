using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
  public class OrdersRepository
  {
    private List<Order> database = new List<Order>();

    public void Insert(Order order)
    {
      database.Add(order);
    }

    public List<Order> GetAll()
    {
      return database;
    }
  }
}
