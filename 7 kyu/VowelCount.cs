// Vowel Count
// https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp
public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        foreach (char letter in str)
        {
            foreach (char vowel in vowels)
            {
                if (letter == vowel)
                {
                    vowelCount++;
                    break;
                }
            }
        }

        return vowelCount;
    }
}
