// Import the static members of Console and DateTime.
using static System.Console;
using static System.DateTime;

// Static classes can only
// contain static members!
static class TimeUtilClass
{
    public static void PrintTime()
    {
        WriteLine(Now.ToShortTimeString());
    }

    public static void PrintDate()
    {
        WriteLine(Today.ToShortDateString());
    }
}