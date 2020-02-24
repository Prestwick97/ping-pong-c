using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter a any positive number.");
    string stringNumber = Console.ReadLine();
    int yourNumber = int.Parse(stringNumber);
    
    List<int> numberList = new List<int> {};
    for (int index = 1; index <= yourNumber; index++)
    {
      numberList.Add(index);
      if ((index % 3) == 0)
      {
        Console.WriteLine("ping");
      }
      else if ((index % 5) == 0) 
      {
        Console.WriteLine("pong");
      } 
      else 
      {
        Console.WriteLine(index);
      }
    }
  }
}