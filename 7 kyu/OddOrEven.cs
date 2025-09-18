//Odd or Even?
// https://www.codewars.com/kata/5949481f86420f59480000e7/train/csharp
using System.Linq;

public class Kata
{
  public static string OddOrEven(int[] array)
  {
      int sum = array.Sum();

      return ((sum % 2) == 0) ? "even" : "odd";
  }
}