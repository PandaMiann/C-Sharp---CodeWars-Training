// Convert boolean values to strings 'Yes' or 'No'.
// https://www.codewars.com/kata/53369039d7ab3ac506000467/train/csharp

public static class Kata
{
    public static string boolToWord(bool word)
    {
        if (word)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
}