using System;

namespace Triangle
{
  public class TriangleTracker
  {
    public int SideOne {get; set;}
    public int SideTwo {get; set;}
    public int SideThree {get; set;}

  public TriangleTracker(int sideOne, int sideTwo, int sideThree)
  {
    SideOne = sideOne;
    SideTwo = sideTwo;
    SideThree = sideThree;
  }
  
  public string createTriangle(int sideOne, int sideTwo, int sideThree)
  {
    if (sideOne + sideTwo <= sideThree || sideTwo + sideThree <= sideOne || sideOne + sideThree <= sideTwo)
    {
      return "This is not a triangle!";
    }
    if (sideOne == sideTwo && sideTwo == sideThree)
    {
      return "This triangle is equilateral!";
    }
    else if (sideOne == sideTwo || sideThree == sideTwo || sideOne == sideThree)
    {
      return "This triangle is isosceles!";
    }
    else if (sideOne != sideTwo && sideThree != sideTwo)
    {
      return "This triangle is scalene!";
    }
    else
    {
      return "This is not a triangle!";
    }
  }
  }
}

  