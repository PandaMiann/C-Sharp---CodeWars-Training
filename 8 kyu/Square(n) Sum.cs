// Square(n) Sum
// https://www.codewars.com/kata/515e271a311df0350d00000f/train/csharp
public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number * number;
        }
        return sum;
    }
}