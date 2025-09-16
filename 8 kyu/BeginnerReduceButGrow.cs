// Beginner - Reduce but Grow
// https://www.codewars.com/kata/57f780909f7e8e3183000078/train/csharp
public class Kata
{
    public static int Grow(int[] x)
    {
        int result = 1;

        for (int number = 0; number < x.Length; number++)
        {
            result *= x[number];
        }
        return result;
    }
}