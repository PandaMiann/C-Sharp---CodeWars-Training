// Disemvowel Trolls
// https://www.codewars.com/kata/52fba66badcd10859f00097e/train/csharp
using System;

public static class Kata
{
  public static string Disemvowel(string str)
  {

      string vowels = "aeiouAEIOU";
      string newString = "";
      foreach (char letter in str)
      {
          if (vowels.IndexOf(letter) == -1)
          {
              newString += letter;
          }
      }
      return newString;
  }
}
