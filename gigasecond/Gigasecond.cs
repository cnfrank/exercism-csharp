using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        // throw new NotImplementedException("You need to implement this function.");
        
        return moment.AddSeconds(1_000_000_000);

    }
}