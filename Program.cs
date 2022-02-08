// See https://aka.ms/new-console-template for more information
using System;

namespace DecoratersPrice
{
  class DecoratersPrice
  {
    public static void Main(string[] args)
    {
    Console.WriteLine("Please State How Many Rooms Need Painting?");
    double NoOfRooms = double.Parse(Console.ReadLine());

    Console.WriteLine("Please State How Many Walls Need Painting?");
    double NoOfWalls = double.Parse(Console.ReadLine());

    Console.WriteLine("Please State How Many Different Colours Would You Like To Use?");
    double NoOfPaints = double.Parse(Console.ReadLine());

    
    }
  }
}
