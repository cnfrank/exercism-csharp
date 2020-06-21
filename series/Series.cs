using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        // throw new NotImplementedException("You need to implement this function.");
        


        string[] res = new string[numbers.Length - sliceLength + 1];
        for (int i = 0; i < numbers.Length - sliceLength + 1; i++)
        {
            res[i] = numbers.Substring(i, sliceLength);
        }

        return res;

    }
}