using System;
using System.Linq;

public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        if (name.StartsWith("r"))
        {
            return (name + " plays banjo");
        }
        if (name.StartsWith("R"))
        {
            return (name + " plays banjo");
        }
        else
        {
            return (name + " does not play banjo");
        }
    }
}