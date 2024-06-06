// This is the Third part of the assignment that starts from page 13
using System;

namespace Program {
  class MyProgram {
    public static void Main(string[] args) {
    }

    // Task 2
    static int StringLength(string str) {
      if (String.IsNullOrEmpty(str)) return 0;

      int length = 0;
      foreach(char letter in str) {
        length++;
      }
      return length;
    }

    // Task 4
    static void PrintReveresed(string str) {
      for (int i = str.Length - 1; i >= 0; i--) {
        Console.Write(str[i]);
      }
    }

    // Task 5
    static int CountWords(string sentence) {
      if (String.IsNullOrEmpty(sentence)) return 0;

      string[] wordsArr = sentence.Split(" ");
      return wordsArr.Length;
    }

    // Task 13
    static string CutAString(int start, int length, string str) {
      string newStr = "";
      for (int i = 0; i < length; i++) {
        newStr += str[start];
        start++;
      }
      return newStr;
    }

    // Task 14
    static string StringHasAWord(string str, string stringValue) {
      if (str.Contains(stringValue)) return "The Substring exist in the string";
      return "The Substring doesn't exist in the string";
    }
    
    // Task 15
    static string SwapCase(string str) {
      string newStr = "";
      for (int i = 0; i < str.Length; i++) {
        if (char.IsUpper(str[i])) {
          newStr += char.ToLower(str[i]);
        } else {
          newStr += char.ToUpper(str[i]);
        }
      }

      // Task 16

      return newStr;
    }

    static int PositionOf(string str, string searchValue) {
      return str.IndexOf(searchValue);
    }
  }
}








