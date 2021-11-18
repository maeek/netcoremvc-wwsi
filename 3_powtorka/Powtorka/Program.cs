using System;
using System.Collections.Generic;


namespace Powtorka
{
  class Program
  {
    static void Operatory1()
    {
      int number = 5;
      float money = 1.1F;
      string text = "Hello";
      bool isLogged = true;
      char myChar = 'y';
      double price = 5.555555;

      Console.WriteLine(number);
      Console.WriteLine(money);
      Console.WriteLine(text);
      Console.WriteLine(isLogged);
      Console.WriteLine(myChar);
      Console.WriteLine(price);
    }

    static void Operatory2()
    {
      string myAge = "Age: ";
      int wifeAge = 18;
      var result = myAge + wifeAge;
      Console.WriteLine(result);
      // wnioski: wypisało "Age: 18"
    }

    static void Operatory3()
    {
      bool isTrue = true;
      bool isFalse = false;
      bool isReallyTrue = true;

      bool and = isTrue && isFalse;
      bool or = isTrue || isReallyTrue;
      bool negative = !isFalse;

      Console.WriteLine(and);
      Console.WriteLine(or);
      Console.WriteLine(negative);
    }

    static void Operatory4()
    {
      var a = 5;
      var b = 12;
      var add = a + b;
      var sub = a - b;
      var div = a / b;
      var mul = a * b;
      var mod = a % b;

      Console.WriteLine(add);
      Console.WriteLine(sub);
      Console.WriteLine(div);
      Console.WriteLine(mul);
      Console.WriteLine(mod);
    }

    static void Operatory5()
    {
      string a = "Ala";
      string b = "ma";
      string c = "kota";
      var result = a + b + c;
      Console.WriteLine(result);
      // wnioski: Wypisało "Alamakota"
    }

    static void Sterujace1()
    {
      int n1 = 10;
      int n2 = 20;
      if (n1 > n2)
      {
        Console.WriteLine("n1 jest większe od n2");
      }
      else if (n1 < n2)
      {
        Console.WriteLine("n1 jest mniejsze od n2");
      }
      else
      {
        Console.WriteLine("n1 jest równe n2");
      }
    }

    static void Sterujace2()
    {
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("c#");
      }

      int j = 0;
      while (j < 10)
      {
        Console.WriteLine("c#");
        j++;
      }
    }

    static void Sterujace3()
    {
      int n = 10;
      for (int i = 0; i < n; i++)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine("Parzysta");
        }
        else
        {
          Console.WriteLine("Nieparzysta");
        }
      }
    }

    static void Sterujace4()
    {
      int n = 5;
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j <= i; j++)
        {
          Console.Write("* ");
        }
        Console.WriteLine();
      }
    }

    static void Kolekcje1()
    {
      string[] colors = new string[4] {
        "red",
        "green",
        "blue",
        "yellow"
      };

      Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
      Console.WriteLine("Mój ostatni kolor to: " + colors[3]);
    }

    static void Kolekcje2()
    {
      int[] numbers = new int[10] {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10
      };

      for (int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine("Liczba: " + numbers[i]);
      }
    }

    static void Kolekcje3()
    {
      List<string> fruits = new List<string>() {
        "apple",
        "banana",
        "orange",
      };
      fruits.Add("kiwi");
      for (int i = 0; i < fruits.Count; i++)
      {
        Console.Write(fruits[i] + ", ");
      }
      Console.WriteLine();
      fruits.Remove("kiwi");
      fruits.RemoveAt(0);
      for (int i = 0; i < fruits.Count; i++)
      {
        Console.Write(fruits[i] + ", ");
      }
      Console.WriteLine();
    }

    static void Main(string[] args)
    {
      // Rozgrzewka
      Console.WriteLine("Podaj swoje imię:");
      var name = Console.ReadLine();
      Console.WriteLine("Hello " + name);

      int result = 5 + 9;

      // Operatory
      // Zadanie 1
      Operatory1();

      // Zadanie 2
      Operatory2();

      // Zadanie 3
      Operatory3();

      // Zadanie 4
      Operatory4();

      // Zadanie 5
      Operatory5();

      // Instrukcje sterujące i pętle
      // Zadanie 1
      Sterujace1();

      // Zadanie 2
      Sterujace2();

      // Zadanie 3
      Sterujace3();

      // Zadanie 4
      Sterujace4();

      // Kolekcje
      // Zadanie 1
      Kolekcje1();

      // Zadanie 2
      Kolekcje2();

      // Zadanie 3
      Kolekcje3();
    }
  }
}
