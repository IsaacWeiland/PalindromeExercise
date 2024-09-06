using System;
using System.Linq;

namespace PalindromeExercise;

public class Stringify
{
    public static string Run(string str)
    {
        return str.ToLower().Replace(" ", "");
    }

    public static string ReverseIt(string str)
    {
        var reverse = str.ToCharArray();
        Array.Reverse(reverse);
        return new string(reverse);
    }
}