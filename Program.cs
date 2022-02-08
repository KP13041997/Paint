// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    int myInt = 2;
    double myDouble = myInt;
    string myRed = "Red Paint & ";
    double red = 13.99;
    string myBlue = "Blue Paint ";
    double blue = 15.79;
    double Name = red + blue; 
      Console.WriteLine("The price of " + myRed + myBlue + "is £" + Name);    
      Console.WriteLine(myInt);
      Console.WriteLine(myDouble);
    }
  }
}
