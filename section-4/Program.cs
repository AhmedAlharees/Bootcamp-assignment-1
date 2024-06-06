// This is the Fourth part of the assignment that starts from page 19

using System;

namespace Program {
  class MyProgram {
    public static void Main(string[] args) {
      SeriesSum(5);
    }
    // Task 1
    static void DisplayNaturalNumbers() {
      for(int i = 1; i <= 10; i++) {
        Console.Write(i + " ");
      }
    }

    // Task 2
    static int SumFirstNaturalNumbers() {
      int sum = 0;
       for(int i = 1; i <= 10; i++) {
        sum += i;
      }
      return sum;
    }

    // Task 9 
    static void DisplayStars() {
      for(int i = 0; i < 4; i++) {
        for (int j = 0; j <= i; j++) {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    // Task 10
    static void DisplayNumbersTriangle() {
      for(int i = 1; i <= 4; i++) {
        for (int j = 1; j <= i; j++) {
          Console.Write(j);
        }
        Console.WriteLine();
      }
    }

    // Task 11
    static void DisplayNumbers() {
      for(int i = 1; i <= 4; i++) {
        for (int j = 1; j <= i; j++) {
          Console.Write(i);
        }
        Console.WriteLine();
      }
    }

    // Task 12
    static void DisplayNumbersSum() {
      for(int i = 1; i <= 4; i++) {
        for (int j = 0; j < i; j++) {
          Console.Write(j + i);
          Console.Write(" ");
        }
        Console.WriteLine();
      }
    }

    // Task 15
    static int Factorial(int num) {
      int fact = 1;
      for (int i = 1; i <= num; i++) {
        fact *= i;
      }
      return fact;
    }

    // Task 16
    static void DisplayEvenNumbers(int num) {
      int sum = 0;
      int[] evenNums = new int[num];
      for (int i = 1; num > 0; i++) {
        if (i % 2 == 0)
          evenNums[num] = i;
          sum += i;
        
        num--;
      }
    } 

    // Task 19
    static void SeriesSum(int num) {
      double sum = 0;
      for (int i = 1; i <= num; i++) {
        sum += (1.00 / i); 
      }
      Console.Write($"Sum of Series upto {num} terms: ");
      Console.Write(sum);
    } 



}
}




