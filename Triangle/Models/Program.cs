using System;
using Triangle;


namespace Triangle
{
public class Program
{
 
  public static void Main()
  {
    Console.WriteLine("Enter a number: ");
    string sideOneInput = Console.ReadLine();
    int sideOne = int.Parse(sideOneInput);

    Console.WriteLine("Enter another number: ");
    string sideTwoInput = Console.ReadLine();
    int sideTwo = int.Parse(sideTwoInput);

    Console.WriteLine("Enter another number: ");
    string sideThreeInput = Console.ReadLine();
    int sideThree = int.Parse(sideThreeInput);
  
  }
}
}