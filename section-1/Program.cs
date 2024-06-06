// This is the first part of the assignment that starts from page 1
using System;

namespace Program {
  class MyProgram {
    public static void Main(string[] args) {
    }

    // Task 1
    static int SumValues_1(int firstValue, int secondValue) {
      if (firstValue == secondValue) {
        return (firstValue + secondValue) * 3;
      }
      return (firstValue + secondValue);
    }

    // Task 2
    static int AbsoluteDifference(int num) {
      if (51 < num) {
        return (num - 51) * 3;
      }
      return 51 - num;
    }

    // Task 3
    static bool SumOrEqual(int firstValue, int secondValue) {
      if ((firstValue + secondValue) == 30 || firstValue == 30 || secondValue == 30) {
        return true;
      }
      return false;
    }

    // Task 4
    static bool IsWithin(int num) {
      return Math.Abs(100 - num) <= 10 || Math.Abs(200 - num) <= 10;
    }

    // Task 5
    static string AddIf(string str) {
      if (str.Substring(0, 2) == "if") {
        return str;
      }
      return "if " + str;
    }

    // Task 6
    static string remove(string str, int num) {
      return str.Substring(0, num) + str.Substring(num + 1);
    }

    // Task 7
    static string Replace(string str) {
      if (String.IsNullOrEmpty(str) || str.Length == 1) return str;

      var firstLetter = str[0];
      var lastLetter  = str[str.Length - 1];

      if (str.Length == 2) return $"{lastLetter}{firstLetter}";

      string restLetter = str.Substring(1, str.Length - 1);

      return lastLetter + restLetter + firstLetter;
    }

    // Task 8
    static string Duplicate(string str) {
      if (String.IsNullOrEmpty(str) || str.Length < 2) return str;

      string firstTwoLetters = str.Substring(0, 2);

      return firstTwoLetters + firstTwoLetters + firstTwoLetters + firstTwoLetters;
    }

    // Task 9
    static string CopyLastChar(string str) {
      string lastChar = str.Substring(str.Length - 1, 1);
      return lastChar + str + lastChar;
    }

    // Task 10
    static bool MultipleOrNot(int num) {
      if (num % 3 == 0 || num % 7 == 0) return true;

      return false;
    }

    // Task 11
    static string RepeatFirst3Letters(string str) {
      if (str.Length < 3) return str + str + str;

      string first_3_letters = str.Substring(0, 3);
      return first_3_letters + str + first_3_letters;
    }

    // Task 12
    static bool StartsWithCSharp(string str) {
      if (str.Substring(0, 2) == "C#")
        return true;
      
      return false;
    }

    // Task 13
    static bool GreaterLessThan(int firstValue, int secondValue ){
      if((firstValue > 100 || firstValue < 0) && (secondValue > 100 || secondValue < 0)) {
        return true;
      }
      return false;
    }

    // Task 14
    static bool InRange(int firstValue, int secondValue) {
      if ((firstValue >= 100 && firstValue <= 200) && (secondValue >= 100 && secondValue <= 200)) {
        return true;
      }

      return false;
    }
  
    // Task 15
    static bool InRange20_50(int firstValue, int secondValue, int thirdValue) {
      if ((firstValue >= 20 && firstValue <= 50) && (secondValue >= 20 && secondValue <= 50) && (thirdValue >= 20 && thirdValue <= 50)) {
        return true;
      }

      return false;
    }

    // Task 16
     static bool InRange20_50(int firstValue, int secondValue) {
      if ((firstValue >= 20 && firstValue <= 50) && (secondValue >= 20 && secondValue <= 50)) {
        return true;
      }

      return false;
    }

    // Task 17
    static string AppearsYT(string str) {
      if (str[1] == 'y' && str[2] == 't') 
        return $"{str.Substring(0, 1)}{str.Substring(3, str.Length-1)}";
      
      return str;
    }

    // Task 18
    static int MaxOfThree(int firstNum, int secondNum, int thirdNum) {
      int currentMax =  Math.Max(firstNum, secondNum);
      return Math.Max(currentMax, thirdNum);
    }

    // Task 19
    static int ClosestTo100(int firstNum, int secondNum) {
      if (Math.Abs(100 - firstNum) > Math.Abs(100 - secondNum))
        return secondNum;
      
      if (Math.Abs(100 - firstNum) < Math.Abs(100 - secondNum))
        return firstNum;

      return 0;
    }

    // Task 22
    static bool ZAmount(string str) {
      if(String.IsNullOrEmpty(str) || str.Length < 2) return false;

      int counter = 0;
      foreach (char letter in str) {
        if (letter == 'z') counter++;
      }

      return ( counter >= 2 && counter <= 4 );
    }

    // Task 23
    static bool HasSameLastDigit(int value1, int value2) {
      string str1 = Convert.ToString(value1);
      string str2 = Convert.ToString(value2);

      return (str1.Substring(str1.Length - 1, 1) == str2.Substring(str2.Length - 1, 1));
    }

    static string LastThreeUpperCase(string str) {
      if(String.IsNullOrEmpty(str)) return str;

      if (str.Length < 3) return str.ToUpper();

      return $"{str.Substring(0, str.Length - 4)}{str.Substring(str.Length - 3).ToUpper()}";
    }

    static string CopyString(int n, string str) {
      if (String.IsNullOrEmpty(str) || n == 0) return str;

      string copy = "";
      for (int i = 0; i < n; i++) {
        copy += str;
      }

      return copy;
    }

  }
}