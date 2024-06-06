// This is the Second part of the assignment, that starts from page 9


using System;

namespace Program {
  class MyProgram {
    public static void Main(string[] args) {
      ValidTriangle(10, 20, 150);
    }
    
    // Task 1
    static string EqualOrNot(int num1, int num2) {
      return (num1 == num2) ? $"{num1}, {num2} are equal" : "";
    }

    // Task 2
    static string EvenOrOdd(int num) {
      return (num % 2 == 0) ? $"{num} is Even" : $"{num} is Odd";
    }

    // Task 4
    static string LeapYearOrNot(int year) {
      return (year % 4 == 0) ? $"{year} is a Leap Year" : $"{year} is not a Leap Year";
    }

    // Task 5
    static void EligibaleOrNot() {
      string canditateAge = Console.ReadLine();
      int age = Convert.ToInt32(canditateAge);

      if (age >= 21) 
        Console.WriteLine("Congratulation! You are eligible for casting your vote");
      else 
        Console.WriteLine("You are not eligible for casting");

    }

    // Task 9
    static void Quadrant(int x, int y) {
      if (x >= 0 && y >= 0) 
        Console.WriteLine($"The coordinate point ({x}, {y}) lies in the First quadrant");

      if (x < 0 && y >= 0) 
        Console.WriteLine($"The coordinate point ({x}, {y}) lies in the second quadrant");

      if (x < 0 && y < 0) 
        Console.WriteLine($"The coordinate point ({x}, {y}) lies in the third quadrant");
      
      if (x >= 0 && y < 0)
        Console.WriteLine($"The coordinate point ({x}, {y}) lies in the fourth quadrant");
    } 

    // Task 14
    static void TriangleType(int value1, int value2, int value3) {
      if (value1 == value2 && value2 == value3) 
        Console.WriteLine("This is an equilateral triangle.");

      if (value1 == value2 || value2 == value3 || value3 == value1)
        Console.WriteLine("This is an isosceles triangle.");

      else {
        Console.WriteLine("This is an scalene triangle.");
      }
    }

    // Task 15
    static void ValidTriangle(int value1, int value2, int value3) {
      if ((value1 + value2 + value3) == 180) 
        Console.WriteLine("The Triangle is Valid");

      else {
        Console.WriteLine("The Triangle is Not Valid");

      }
    }




  }
}