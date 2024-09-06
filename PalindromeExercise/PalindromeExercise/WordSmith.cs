using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string str)
    {
        var stringified = Stringify.Run(str);
        var reverseString = Stringify.ReverseIt(stringified);
        if (stringified == reverseString)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}