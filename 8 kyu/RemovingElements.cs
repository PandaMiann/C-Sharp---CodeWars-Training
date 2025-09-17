//Removing Elements
// https://www.codewars.com/kata/5769b3802ae6f8e4890009d2/solutions/csharp
using System.Collections.Generic;

  public static class Kata
    {
      public static object[] RemoveEveryOther(object[] arr)
        {
            List<object> list = new List<object>();

            for (int i = 0; i < arr.Length; i += 2)
            {
                list.Add(arr[i]);
            }
            return list.ToArray();
          }
    }